using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2;

public class ChaChaTests
{
[Fact]
    public void Load32_ShouldLoadCorrectValue_WhenGivenBytesAndIndex()
    {
        // Arrange
        var chacha = new ChaCha();
        byte[] bytes = { 1, 2, 3, 4, 5, 6, 7, 8 };

        // Act
        uint result = chacha.Load32(bytes, 2);

        // Assert
        Assert.Equal((uint)0x04030201, result);
    }

    [Fact]
    public void Store32_ShouldStoreCorrectValue_WhenGivenBytesIndexAndValue()
    {
        // Arrange
        var chacha = new ChaCha();
        byte[] bytes = new byte[8];
        uint value = 0x04030201;

        // Act
        chacha.Store32(bytes, 2, value);

        // Assert
        Assert.Equal(new byte[] { 0, 0, 1, 2, 3, 4, 0, 0 }, bytes);
    }

    [Fact]
    public void GetRounds_ShouldApplyRoundsCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        uint[] state = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        uint[] expectedState = (uint[])state.Clone();

        // Act
        chacha.GetRounds(state);

        // Assert
        Assert.NotEqual(expectedState, state);
    }

    [Fact]
    public void Round_ShouldApplyRoundCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        uint a = 1, b = 2, c = 3, d = 4;
        uint expectedA = a + b;
        uint expectedB = (b ^ c) << 12;
        uint expectedC = c + d;
        uint expectedD = (d ^ a) << 16;

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
        uint value = 0x12345678;
        uint expected = 0x23456781;

        // Act
        uint result = chacha.RotateLeft(value, 4);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Init_ShouldInitializeCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        byte[] key = { 1, 2, 3, 4, 5, 6, 7, 8 };
        byte[] nonce = { 9, 10, 11, 12, 13, 14 };
        uint[] expectedState = new uint[]
        {
            1634760805, 857760878, 2036477234, 1797285236,
            1, 2, 3, 4, 5, 6, 7, 8, 0, 0, 11979595, 236439307
        };

        // Act
        uint[] result = chacha.Init(key, nonce);

        // Assert
        Assert.Equal(expectedState, result);
    }

    [Fact]
    public void Base64Encode_ShouldEncodeCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        string input = "Hello, World!";
        string expected = "SGVsbG8sIFdvcmxkIQ==";

        // Act
        string result = ChaCha.Base64Encode(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Base64Decode_ShouldDecodeCorrectly()
    {
        // Arrange
        var chacha = new ChaCha();
        string input = "SGVsbG8sIFdvcmxkIQ==";
        string expected = "Hello, World!";

        // Act
        string result = ChaCha.Base64Decode(input);

        // Assert
        Assert.Equal(expected, result);
    }
}