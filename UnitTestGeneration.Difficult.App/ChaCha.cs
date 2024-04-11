using System.Security.Cryptography;
using System.Text;

namespace UnitTestGeneration.Difficult.App;
// https://github.com/LandSharkFive/SimpleChaCha/blob/main/ChaChaOne/Util.cs
// cy = 20, co = 16
public class ChaCha
{
        // The input is 64 bytes (512 bits).
        private uint[] Input = new uint[16];


        /// <summary>
        /// Load 32 bits.
        /// </summary>
        /// <param name="x">byte[]</param>
        /// <param name="i">int</param>
        /// <returns>uint</returns>
        private uint Load32(byte[] x, int i)
        {
            return (UInt32)(x[i] | (x[i + 1] << 8) | (x[i + 2] << 16) | (x[i + 3] << 24));
        }

        /// <summary>
        /// Store 32 bits.
        /// </summary>
        /// <param name="x">byte[]</param>
        /// <param name="i">int</param>
        /// <param name="u">uint</param>
        private void Store32(byte[] x, int i, uint u)
        {
            x[i] = (byte)(u & 0xff);
            u >>= 8;
            x[i + 1] = (byte)(u & 0xff);
            u >>= 8;
            x[i + 2] = (byte)(u & 0xff);
            u >>= 8;
            x[i + 3] = (byte)(u & 0xff);
        }

        /// <summary>
        /// Demo.  Encrypt and Decrypt a string.
        /// </summary>
        public void Demo()
        {
            var key = new byte[32];
            RandomNumberGenerator.Create().GetBytes(key);

            // The nonce includes the IV.  Each message must have a unique nonce.
            // Do not use the same nonce twice.
            var nonce = new byte[24];
            RandomNumberGenerator.Create().GetBytes(nonce);

            Console.WriteLine("key={0}", System.Convert.ToBase64String(key));
            Console.WriteLine("nonce={0}", System.Convert.ToBase64String(nonce));
            Console.WriteLine();

            string input = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing " +
                "and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                "It has survived not only five centuries, but also the leap into electronic typesetting, remaining " +
                "essentially unchanged. It was popularized in the 1960s with the release of Letraset sheets containing " +
                "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including " +
                "versions of Lorem Ipsum.";

            var ctx = Init(key, nonce);

            // plain text
            byte[] pt = Encoding.UTF8.GetBytes(input);

            // cipher text
            byte[] ct = new byte[pt.Length];

            // Encrypt into cipher text (ct).
            Encrypt(ctx, ct, pt, pt.Length);

            Console.WriteLine("pt={0}", input);
            Console.WriteLine("len={0}", input.Length);
            Console.WriteLine("hash={0}", Math.Abs(input.GetHashCode()));
            Console.WriteLine();

            Console.WriteLine("ct={0}", System.Convert.ToBase64String(ct));
            Console.WriteLine("len={0}", ct.Length);
            Console.WriteLine();

            ctx = Init(key, nonce);

            // decrypted text
            byte[] dt = new byte[ct.Length];
            Encrypt(ctx, dt, ct, pt.Length);

            string output = Encoding.UTF8.GetString(dt, 0, dt.Length);

            Console.WriteLine("dt={0}", output);
            Console.WriteLine("len={0}", output.Length);
            Console.WriteLine("hash={0}", Math.Abs(output.GetHashCode()));
            Console.WriteLine();
        }

        /// <summary>
        /// Encrypt and Decrypt a string
        /// </summary>
        /// <param name="ctx">uint[]</param>
        /// <param name="dst">byte[]</param>
        /// <param name="src">byte[]</param>
        /// <param name="len">int</param>
        public void Encrypt(uint[] ctx, byte[] dst, byte[] src, int len)
        {
            uint[] x = new uint[16];
            byte[] buf = new byte[64];
            int i = 0;
            int dstPos = 0;
            int srcPos = 0;
            while (len > 0)
            {
                for (i = 0; i < 16; i++)
                {
                    x[i] = ctx[i];
                }
                GetRounds(x);
                for (i = 0; i < 16; i++)
                {
                    x[i] += ctx[i];
                }
                for (i = 0; i < 16; i++)
                {
                    Store32(buf, i * 4, x[i]);
                }

                // nonce
                ctx[12] += 1;
                if (ctx[12] == 0)
                {
                    ctx[13] += 1;
                }

                if (len < 64)
                {
                    break;
                }

                for (i = 0; i < 64; i++)
                {
                    dst[i + dstPos] = (byte)(src[i + srcPos] ^ buf[i]);
                }

                len -= 64;
                srcPos += 64;
                dstPos += 64;
            }

            // left over bytes
            // This should never happen.  The plain text should be right padded
            // with dummy characters.  The last byte is the padding length.
            for (i = 0; i < len; i++)
            {
                dst[i + dstPos] = (byte)(src[i + srcPos] ^ buf[i]);
            }

        }


        /// <summary>
        /// Ten rounds of left bit shifting and exclusive or.
        /// </summary>
        /// <param name="state">uint[]</param>
        public void GetRounds(uint[] state)
        {
            for (var i = 0; i < 10; i++)
            {
                // The compiler generates better code with references.
                Round(ref state[0], ref state[4], ref state[8], ref state[12]);
                Round(ref state[1], ref state[5], ref state[9], ref state[13]);
                Round(ref state[2], ref state[6], ref state[10], ref state[14]);
                Round(ref state[3], ref state[7], ref state[11], ref state[15]);
                Round(ref state[0], ref state[5], ref state[10], ref state[15]);
                Round(ref state[1], ref state[6], ref state[11], ref state[12]);
                Round(ref state[2], ref state[7], ref state[8], ref state[13]);
                Round(ref state[3], ref state[4], ref state[9], ref state[14]);
            }
        }


        /// <summary>
        /// One round of exclusive or and left bit shifting.
        /// </summary>
        /// <param name="x">byte array</param>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <param name="c">int</param>
        /// <param name="d">int</param>
        private void Round(ref uint a, ref uint b, ref uint c, ref uint d)
        {
            // The compiler generates better code with references.
            a += b;
            d = RotateLeft(d ^ a, 16);
            c += d;
            b = RotateLeft(b ^ c, 12);
            a += b;
            d = RotateLeft(d ^ a, 8);
            c += d;
            b = RotateLeft(b ^ c, 7);
        }

        // Rotate value left by count bits.
        private uint RotateLeft(uint value, int count)
        {
            return (value << count) | (value >> (32 - count));
        }

        /// <summary>
        /// Initialize the byte array with key and nonce.
        /// </summary>
        /// <param name="key">byte[]</param>
        /// <param name="nonce">byte[]</param>
        /// <returns>uint[]</returns>
        private uint[] Init(byte[] key, byte[] nonce)
        {
            var result = new uint[16];

            result[0] = 1634760805;
            result[1] = 857760878;
            result[2] = 2036477234;
            result[3] = 1797285236;
            result[12] = 0;
            result[13] = 0;
            result[14] = Load32(nonce, 0);
            result[15] = Load32(nonce, 4);

            for (var i = 0; i < 8; i++)
            {
                result[i + 4] = Load32(key, i * 4);
            }

            return result;
        }

        /// <summary>
        /// Base 64 encode.
        /// </summary>
        /// <param name="plainText">string</param>
        /// <returns>string</returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Base 64 decode.
        /// </summary>
        /// <param name="base64EncodedData">string</param>
        /// <returns>string</returns>
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
}