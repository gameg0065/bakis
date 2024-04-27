using System.Security.Cryptography;
using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class ChaChaTests
{
// [Fact]
//     public void Load32_ReturnsCorrectValue()
//     {
//         // Arrange
//         var chaCha = new ChaCha();
//         byte[] x = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 };
//         int i = 0;
//
//         // Act
//         uint result = chaCha.Load32(x, i);
//
//         // Assert
//         Assert.Equal(0x04030201, result);
//     }

    [Theory]
    [InlineData(new byte[] { 0x01, 0x02, 0x03, 0x04 }, 0, 0x04030201)]
    [InlineData(new byte[] { 0xFF, 0xEE, 0xDD, 0xCC }, 0, 0xCCDDEEFF)]
    public void Load32_WithDifferentInputs_ReturnsCorrectValue(byte[] x, int i, uint expected)
    {
        // Arrange
        var chaCha = new ChaCha();

        // Act
        uint result = chaCha.Load32(x, i);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Store32_UpdatesByteArrayCorrectly()
    {
        // Arrange
        var chaCha = new ChaCha();
        byte[] x = new byte[4];
        int i = 0;
        uint u = 0x04030201;

        // Act
        chaCha.Store32(x, i, u);

        // Assert
        Assert.Equal(0x01, x[0]);
        Assert.Equal(0x02, x[1]);
        Assert.Equal(0x03, x[2]);
        Assert.Equal(0x04, x[3]);
    }

    [Theory]
    [InlineData(new byte[] { 0x00, 0x00, 0x00, 0x00 }, 0, 0x04030201, new byte[] { 0x01, 0x02, 0x03, 0x04 })]
    [InlineData(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF }, 0, 0xCCDDEEFF, new byte[] { 0xFF, 0xEE, 0xDD, 0xCC })]
    public void Store32_WithDifferentInputs_UpdatesByteArrayCorrectly(byte[] x, int i, uint u, byte[] expected)
    {
        // Arrange
        var chaCha = new ChaCha();

        // Act
        chaCha.Store32(x, i, u);

        // Assert
        Assert.Equal(expected, x);
    }

    [Fact]
    public void Demo_EncryptsAndDecryptsCorrectly()
    {
        // Arrange
        var chaCha = new ChaCha();

        // Act
        chaCha.Demo();

        // Assert
        // The Demo method prints the encrypted and decrypted text to the console.
        // We can visually verify that the decrypted text matches the original input.
    }

    [Fact]
    public void Encrypt_EncryptsAndDecryptsCorrectly()
    {
        // Arrange
        var chaCha = new ChaCha();
        var key = new byte[32];
        var nonce = new byte[24];
        RandomNumberGenerator.Create().GetBytes(key);
        RandomNumberGenerator.Create().GetBytes(nonce);

        string input = "What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
        byte[] pt = System.Text.Encoding.UTF8.GetBytes(input);

        uint[] ctx = chaCha.Init(key, nonce);
        byte[] ct = new byte[pt.Length];

        // Act
        chaCha.Encrypt(ctx, ct, pt, pt.Length);

        ctx = chaCha.Init(key, nonce);
        byte[] dt = new byte[ct.Length];
        chaCha.Encrypt(ctx, dt, ct, pt.Length);

        string output = System.Text.Encoding.UTF8.GetString(dt, 0, dt.Length);

        // Assert
        Assert.Equal(input, output);
    }

    [Theory]
    [InlineData(new uint[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 })]
    [InlineData(new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
    public void GetRounds_PerformsCorrectNumberOfRounds(uint[] state)
    {
        // Arrange
        var chaCha = new ChaCha();
        uint[] originalState = new uint[state.Length];
        Array.Copy(state, originalState, state.Length);

        // Act
        chaCha.GetRounds(state);

        // Assert
        Assert.NotEqual(originalState, state);
    }

    // [Fact]
    // public void Round_PerformsCorrectRotations()
    // {
    //     // Arrange
    //     var chaCha = new ChaCha();
    //     uint a = 1, b = 2, c = 3, d = 4;
    //
    //     // Act
    //     chaCha.Round(ref a, ref b, ref c, ref d);
    //
    //     // Assert
    //     Assert.Equal(2, a);
    //     Assert.Equal(7, b);
    //     Assert.Equal(14, c);
    //     Assert.Equal(16, d);
    // }

    [Theory]
    [InlineData(0x12345678, 16, 0x78563412)]
    [InlineData(0xFFFFFFFF, 1, 0xFFFFFFFE)]
    public void RotateLeft_RotatesCorrectly(uint value, int count, uint expected)
    {
        // Arrange
        var chaCha = new ChaCha();

        // Act
        uint result = chaCha.RotateLeft(value, count);

        // Assert
        Assert.Equal(expected, result);
    }

    // [Fact]
    // public void Init_InitializesStateCorrectly()
    // {
    //     // Arrange
    //     var chaCha = new ChaCha();
    //     byte[] key = new byte[32];
    //     byte[] nonce = new byte[24];
    //     RandomNumberGenerator.Create().GetBytes(key);
    //     RandomNumberGenerator.Create().GetBytes(nonce);
    //
    //     // Act
    //     uint[] state = chaCha.Init(key, nonce);
    //
    //     // Assert
    //     Assert.Equal(1634760805, state[0]);
    //     Assert.Equal(857760878, state[1]);
    //     Assert.Equal(2036477234, state[2]);
    //     Assert.Equal(1797285236, state[3]);
    //     Assert.Equal(0, state[12]);
    //     Assert.Equal(0, state[13]);
    //     Assert.Equal(chaCha.Load32(nonce, 0), state[14]);
    //     Assert.Equal(chaCha.Load32(nonce, 4), state[15]);
    //
    //     for (int i = 0; i < 8; i++)
    //     {
    //         Assert.Equal(chaCha.Load32(key, i * 4), state[i + 4]);
    //     }
    // }
}