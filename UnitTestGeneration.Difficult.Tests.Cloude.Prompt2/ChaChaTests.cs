using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class ChaChaTests
{
    [Fact]
    public void Load32_ShouldLoadBytesCorrectly()
    {
        // Arrange
        byte[] bytes = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 };
        uint expected = 0x04030201;
        var chacha = new ChaCha();

        // Act
        uint result = chacha.Load32(bytes, 0);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Store32_ShouldStoreBytesCorrectly()
    {
        // Arrange
        byte[] bytes = new byte[4];
        uint value = 0x04030201;
        var chacha = new ChaCha();

        // Act
        chacha.Store32(bytes, 0, value);

        // Assert
        Assert.Equal(0x01, bytes[0]);
        Assert.Equal(0x02, bytes[1]);
        Assert.Equal(0x03, bytes[2]);
        Assert.Equal(0x04, bytes[3]);
    }

    [Fact]
    public void Encrypt_ShouldEncryptAndDecryptCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        byte[] key = new byte[32];
        byte[] nonce = new byte[24];
        string plainText = "Hello, World!";
        byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);

        // Act
        uint[] ctx = chacha.Init(key, nonce);
        byte[] cipherText = new byte[plainTextBytes.Length];
        chacha.Encrypt(ctx, cipherText, plainTextBytes, plainTextBytes.Length);

        ctx = chacha.Init(key, nonce);
        byte[] decryptedBytes = new byte[cipherText.Length];
        chacha.Encrypt(ctx, decryptedBytes, cipherText, cipherText.Length);
        string decryptedText = System.Text.Encoding.UTF8.GetString(decryptedBytes);

        // Assert
        Assert.Equal(plainText, decryptedText);
    }

    [Fact]
    public void GetRounds_ShouldPerformRoundsCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        uint[] state = { 0x61707865, 0x3320646e, 0x79622d32, 0x6b206574,
                         0x03020100, 0x07060504, 0x0b0a0908, 0x0f0e0d0c,
                         0x13121110, 0x17161514, 0x1b1a1918, 0x1f1e1d1c,
                         0x23222120, 0x27262524, 0x2b2a2928, 0x2f2e2d2c };

        uint[] expectedState = { 0x8fa9e637, 0x538ccff4, 0x0f8a083d, 0x699c15a1,
                                 0x6e5e5662, 0x91bfddf4, 0x04aa7b35, 0x8e3751b9,
                                 0xd9470f3f, 0x9f5d76e3, 0x705df851, 0x35c31567,
                                 0x69435388, 0x3e57eba3, 0x93c166c5, 0x2e7b4a6d };

        // Act
        chacha.GetRounds(state);

        // Assert
        Assert.Equal(expectedState, state);
    }

    [Fact]
    public void Round_ShouldPerformRoundCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        uint a = 0x11111111, b = 0x01020304, c = 0x05060708, d = 0x09090909;
        uint expectedA = 0xeaa9d07a, expectedB = 0x48dd7618, expectedC = 0x14e9f8e2, expectedD = 0xd1318592;

        // Act
        chacha.Round(ref a, ref b, ref c, ref d);

        // Assert
        Assert.Equal(expectedA, a);
        Assert.Equal(expectedB, b);
        Assert.Equal(expectedC, c);
        Assert.Equal(expectedD, d);
    }

    [Fact]
    public void RotateLeft_ShouldRotateCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        uint value = 0x01234567;
        uint expected = 0x45670123;

        // Act
        uint result = chacha.RotateLeft(value, 16);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Init_ShouldInitializeStateCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        byte[] key = new byte[32];
        byte[] nonce = new byte[24];
        uint[] expectedState = { 1634760805, 857760878, 2036477234, 1797285236,
                                 0, 0, 0, 0,
                                 0, 0, 0, 0,
                                 0, 0, Load32(nonce, 0), Load32(nonce, 4) };

        // Act
        uint[] state = chacha.Init(key, nonce);

        // Assert
        Assert.Equal(expectedState, state);
    }

    [Fact]
    public void Base64Encode_ShouldEncodeCorrectly()
    {
        // Arrange
        string plainText = "Hello, World!";
        string expected = "SGVsbG8sIFdvcmxkIQ==";

        // Act
        string result = ChaCha.Base64Encode(plainText);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Base64Decode_ShouldDecodeCorrectly()
    {
        // Arrange
        string base64EncodedData = "SGVsbG8sIFdvcmxkIQ==";
        string expected = "Hello, World!";

        // Act
        string result = ChaCha.Base64Decode(base64EncodedData);

        // Assert
        Assert.Equal(expected, result);
    }

    private uint Load32(byte[] x, int i)
    {
        return (uint)(x[i] | (x[i + 1] << 8) | (x[i + 2] << 16) | (x[i + 3] << 24));
    }
}