using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt2;

public class ChaChaTests
{
    [Theory]
    [InlineData(new byte[] { 1, 0, 0, 0 }, 0, 1)]
    [InlineData(new byte[] { 0, 1, 0, 0 }, 0, 256)]
    [InlineData(new byte[] { 0, 0, 0, 1 }, 3, 16777216)] 
    public void Load32_ReturnsCorrectValue(byte[] input, int index, uint expected)
    {
        var chaCha = new ChaCha();
        uint result = chaCha.Load32(input, index);
        Assert.Equal(expected, result);
    }

    // [Theory]
    // [InlineData(new byte[4], 0, 1)] 
    // [InlineData(new byte[4], 0, 65536)] // Test value above 255
    // public void Store32_CorrectlySetsBytes(byte[] output, int index, uint value)
    // {
    //     var chaCha = new ChaCha();
    //     chaCha.Store32(output, index, value);
    //     // Assert the expected bytes in 'output' based on the value 
    // }
    //
    // [Fact]
    // public void Init_SetsStateCorrectly()
    // {
    //     byte[] key = new byte[32]; 
    //     byte[] nonce = new byte[24];
    //
    //     // You might want to use predictable values here for test purposes
    //
    //     var chaCha = new ChaCha();
    //     uint[] state = chaCha.Init(key, nonce);
    //
    //     // Assert values in 'state' against expected hardcoded values 
    //     Assert.Equal(1634760805, state[0]);
    //     Assert.Equal(857760878, state[1]);
    //     // ... and so on 
    // }
    
    
}