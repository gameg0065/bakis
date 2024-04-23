using System.Security.Cryptography;
using System.Text;
using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class ChaChaTests
{
[Fact]
    public void Load32_ShouldReturnCorrectValue()
    {
        // Arrange
        var chacha = new ChaCha();
        var bytes = new byte[] { 0x01, 0x02, 0x03, 0x04 };

        // Act
        var result = chacha.Load32(bytes, 0);

        // Assert
        Assert.Equal((uint)0x04030201, result);
    }

    [Fact]
    public void Store32_ShouldSetCorrectBytes()
    {
        // Arrange
        var chacha = new ChaCha();
        var bytes = new byte[4];
        uint value = 0x04030201;

        // Act
        chacha.Store32(bytes, 0, value);

        // Assert
        Assert.Equal(new byte[] { 0x01, 0x02, 0x03, 0x04 }, bytes);
    }

    [Fact]
    public void RotateLeft_ShouldRotateCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        uint value = 0x01234567;

        // Act
        var result = chacha.RotateLeft(value, 4);

        // Assert
        Assert.Equal((uint)0x12345670, result);
    }

    [Fact]
    public void Round_ShouldOperateCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        uint a = 0x01234567;
        uint b = 0x89ABCDEF;
        uint c = 0xFEDCBA98;
        uint d = 0x76543210;

        // Act
        chacha.Round(ref a, ref b, ref c, ref d);

        // Assert
        Assert.Equal((uint)0x89012345, a);
        Assert.Equal((uint)0xD000FEDC, b);
        Assert.Equal((uint)0xEF765432, c);
        Assert.Equal((uint)0x67452301, d);
    }

    [Fact]
    public void GetRounds_ShouldOperateCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        var state = new uint[] { 0x01234567, 0x89ABCDEF, 0xFEDCBA98, 0x76543210 };

        // Act
        chacha.GetRounds(state);

        // Assert
        Assert.Equal((uint)0x01234567, state[0]);
        Assert.Equal((uint)0x89ABCDEF, state[1]);
        Assert.Equal((uint)0xFEDCBA98, state[2]);
        Assert.Equal((uint)0x76543210, state[3]);
    }

    [Fact]
    public void Encrypt_ShouldEncryptCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        var key = new byte[32];
        var nonce = new byte[24];
        RandomNumberGenerator.Create().GetBytes(key);
        RandomNumberGenerator.Create().GetBytes(nonce);
        var ctx = chacha.Init(key, nonce);
        string input = "Test Input";
        byte[] pt = Encoding.UTF8.GetBytes(input);
        byte[] ct = new byte[pt.Length];

        // Act
        chacha.Encrypt(ctx, ct, pt, pt.Length);

        // Assert
        Assert.NotEqual(pt, ct);
    }

    [Fact]
    public void Base64Encode_And_Decode_ShouldWorkCorrectly()
    {
        // Arrange
        string input = "Test Input";
        
        // Act
        var encoded = ChaCha.Base64Encode(input);
        var decoded = ChaCha.Base64Decode(encoded);

        // Assert
        Assert.NotEqual(input, encoded);
        Assert.Equal(input, decoded);
    }
}