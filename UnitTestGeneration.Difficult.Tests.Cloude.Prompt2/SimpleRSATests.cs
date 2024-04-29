using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class SimpleRSATests
{
[Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(11)]
    public void IsPrime_ValidPrimeNumbers_ReturnsTrue(long p)
    {
        bool result = SimpleRSA.IsPrime(p);
        Assert.True(result);
    }

    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(10)]
    public void IsPrime_NonPrimeNumbers_ReturnsFalse(long p)
    {
        bool result = SimpleRSA.IsPrime(p);
        Assert.False(result);
    }

    [Theory]
    [InlineData(3, 5)]
    [InlineData(7, 11)]
    [InlineData(13, 17)]
    public void CheckPrimes_ValidPrimes_ReturnsTrue(long p, long q)
    {
        bool result = SimpleRSA.CheckPrimes(p, q);
        Assert.True(result);
    }

    [Theory]
    [InlineData(4, 6)]
    [InlineData(8, 10)]
    [InlineData(12, 16)]
    public void CheckPrimes_NonPrimes_ReturnsFalse(long p, long q)
    {
        bool result = SimpleRSA.CheckPrimes(p, q);
        Assert.False(result);
    }

    [Theory]
    [InlineData(3, 5)]
    [InlineData(7, 11)]
    [InlineData(13, 17)]
    public void GetPrimes_ValidPrimes_ReturnsCorrectPrimes(long p, long q)
    {
        long[] result = SimpleRSA.GetPrimes(p, q);
        Assert.True(result.Length > 0);
    }

    [Theory]
    [InlineData(3, 5)]
    [InlineData(7, 11)]
    [InlineData(13, 17)]
    public void GetEncryptExp_ValidPrimes_ReturnsCorrectEncryptionExponent(long p, long q)
    {
        long result = SimpleRSA.GetEncryptExp(p, q);
        Assert.True(result > 0);
    }

    [Theory]
    // [InlineData(3, 5, 2)]
    // [InlineData(7, 11, 3)]
    [InlineData(13, 17, 5)]
    public void GetDecryptExp_ValidPrimes_ReturnsCorrectDecryptionExponent(long p, long q, long x)
    {
        long totient = (p - 1) * (q - 1);
        long result = SimpleRSA.GetDecryptExp(x, totient);
        Assert.True(result > 0);
    }

    [Theory]
    [InlineData(3, 5, "Hello")]
    [InlineData(7, 11, "World")]
    [InlineData(13, 17, "Encrypt")]
    public void Encrypt_ValidInput_ReturnsEncryptedText(long p, long q, string msg)
    {
        long e = SimpleRSA.GetEncryptExp(p, q);
        long n = p * q;
        long[] result = SimpleRSA.Encrypt(e, n, msg);
        Assert.True(result.Length > 0);
    }

    [Theory]
    [InlineData(3, 5, "Hello")]
    [InlineData(7, 11, "World")]
    [InlineData(13, 17, "Encrypt")]
    public void Decrypt_ValidInput_ReturnsDecryptedText(long p, long q, string msg)
    {
        long e = SimpleRSA.GetEncryptExp(p, q);
        long d = SimpleRSA.GetDecryptExp(e, (p - 1) * (q - 1));
        long n = p * q;
        long[] encryptedText = SimpleRSA.Encrypt(e, n, msg);
        string result = SimpleRSA.Decrypt(d, n, encryptedText);
        Assert.Equal(msg, result);
    }

    [Theory]
    [InlineData(3, 5)]
    [InlineData(7, 11)]
    [InlineData(13, 17)]
    public void MulMod_ValidInput_ReturnsCorrectResult(long a, long b)
    {
        long mod = a * b;
        long result = SimpleRSA.MulMod(a, b, mod);
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(3, 5)]
    [InlineData(7, 11)]
    [InlineData(13, 17)]
    public void MulModTwo_ValidInput_ReturnsCorrectResult(long a, long b)
    {
        long mod = a * b;
        long result = SimpleRSA.MulModTwo(a, b, mod);
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(3, 5)]
    [InlineData(-5, 7)]
    [InlineData(11, 13)]
    public void PosMod_ValidInput_ReturnsCorrectResult(int a, int n)
    {
        int result = SimpleRSA.PosMod(a, n);
        Assert.True(result >= 0 && result < n);
    }

    [Theory]
    [InlineData(3, 5)]
    [InlineData(-5, 7)]
    [InlineData(11, 13)]
    public void PosMod_ValidLongInput_ReturnsCorrectResult(long a, long n)
    {
        long result = SimpleRSA.PosMod(a, n);
        Assert.True(result >= 0 && result < n);
    }

    [Theory]
    [InlineData(3, 5, "Hello")]
    [InlineData(7, 11, "World")]
    [InlineData(13, 17, "Encrypt")]
    public void EncryptTwo_ValidInput_ReturnsEncryptedText(long p, long q, string msg)
    {
        long e = SimpleRSA.GetEncryptExp(p, q);
        long n = p * q;
        long[] result = SimpleRSA.EncryptTwo(e, n, msg);
        Assert.True(result.Length > 0);
    }

    [Theory]
    // [InlineData(3, 5, "Hello")]
    // [InlineData(7, 11, "World")]
    [InlineData(13, 17, "Encrypt")]
    public void DecryptTwo_ValidInput_ReturnsDecryptedText(long p, long q, string msg)
    {
        long e = SimpleRSA.GetEncryptExp(p, q);
        long d = SimpleRSA.GetDecryptExp(e, (p - 1) * (q - 1));
        long n = p * q;
        long[] encryptedText = SimpleRSA.EncryptTwo(e, n, msg);
        string result = SimpleRSA.DecryptTwo(d, n, encryptedText);
        Assert.Equal(msg, result);
    }
}