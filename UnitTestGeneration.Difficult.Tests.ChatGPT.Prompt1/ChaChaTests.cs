using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1;

public class ChaChaTests
{
    // [Fact]
    // public void Load32_ShouldReturnCorrectValue()
    // {
    //     // Arrange
    //     var chaCha = new ChaCha();
    //     byte[] x = { 0x01, 0x02, 0x03, 0x04 };
    //     int i = 0;
    //
    //     // Act
    //     uint result = chaCha.Load32(x, i);
    //
    //     // Assert
    //     Assert.Equal(0x04030201, result);
    // }

    [Fact]
    public void Store32_ShouldStoreCorrectValue()
    {
        // Arrange
        var chaCha = new ChaCha();
        byte[] x = new byte[4];
        int i = 0;
        uint u = 0x04030201;

        // Act
        chaCha.Store32(x, i, u);

        // Assert
        Assert.Equal(new byte[] { 0x01, 0x02, 0x03, 0x04 }, x);
    }

    [Fact]
    public void RotateLeft_ShouldReturnCorrectValue()
    {
        // Arrange
        var chaCha = new ChaCha();
        uint value = 0x80000000;
        int count = 1;

        // Act
        uint result = chaCha.RotateLeft(value, count);

        // Assert
        Assert.Equal(1u, result);
    }

    [Fact]
    public void Base64Encode_Decode_ShouldReturnOriginalString()
    {
        // Arrange
        var chaCha = new ChaCha();
        string input = "Hello, world!";

        // Act
        string encoded = ChaCha.Base64Encode(input);
        string decoded = ChaCha.Base64Decode(encoded);

        // Assert
        Assert.Equal(input, decoded);
    }
}