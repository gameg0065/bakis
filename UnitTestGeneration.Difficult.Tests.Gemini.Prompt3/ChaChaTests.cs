using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt3;

public class ChaChaTests
{
    [Theory]
    [InlineData(new byte[] { 0x01, 0x02, 0x03, 0x04 }, 0, 0x04030201)] 
    [InlineData(new byte[] { 0xFF, 0xEE, 0xDD, 0xCC }, 0, 0xCCDDEEFF)]
    [InlineData(new byte[] { 0xFF, 0xEE, 0xDD, 0xCC }, 1, 0xDDCCFFEE)] // Offset test
    public void Load32_ShouldReturnCorrectUIntRepresentations(byte[] input, int startIndex, uint expected)
    {
        var chacha = new ChaCha();

        var result = chacha.Load32(input, startIndex);

        Assert.Equal(expected, result);
    }

    // ... Similar tests for Store32

    [Theory]
    [InlineData(0xABCDEF12, 16, 0xEF12ABCD)]
    [InlineData(0x87654321, 8,  0x65432187)]
    public void RotateLeft_ShouldRotateCorrectly(uint input, int count, uint expected)
    {
        var chacha = new ChaCha();

        uint result = chacha.RotateLeft(input, count);

        Assert.Equal(expected, result);
    }
}