using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class ChaChaTests
{
    [Theory]
    [InlineData(new byte[] { 0xDE, 0xAD, 0xBE, 0xEF }, 0, 0xEFBEADDE)]
    // Add more test cases with different byte arrays and offsets
    public void Load32_ConvertsBytesToInteger(byte[] input, int offset, uint expectedOutput)
    {
        var chacha = new ChaCha();
        var result = chacha.Load32(input, offset);

        Assert.Equal(expectedOutput, result);
    }

    [Theory]
    [InlineData(0xEFBEADDE, 16, 0xDEADBEEF)] // Example rotation
    // Add more cases with different input values and shift counts
    public void RotateLeft_ShiftsBitsCorrectly(uint input, int shiftCount, uint expectedOutput)
    {
        var chacha = new ChaCha();
        var result = chacha.RotateLeft(input, shiftCount);

        Assert.Equal(expectedOutput, result);
    }

    // [Fact]
    // public void Init_SetsInternalState() 
    // {
    //     var key = new byte[32] { /* Example key */ }; 
    //     var nonce = new byte[24] { /* Example nonce */ }; 
    //     var chacha = new ChaCha();
    //
    //     var state = chacha.Init(key, nonce);
    //
    //     // Assertions on specific state values.
    //     Assert.Equal(1634760805, state[0]); 
    //     Assert.Equal(857760878, state[1]); 
    //     // ... more assertions
    // }
}