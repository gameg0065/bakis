using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt2;

public class SimpleRSATests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(17, true)]  
    [InlineData(25, false)] 
    [InlineData(1, false)] // Edge case
    public void IsPrime_ReturnsCorrectResult(long input, bool expected)
    {
        var result = SimpleRSA.IsPrime(input);
        Assert.Equal(expected, result);
    }

    
    // [Fact]
    // public void EncryptDecrypt_RoundTrip_OriginalMessageRestored()
    // {
    //     // Set up valid p, q, generate keys (encryption and decryption)
    //     long p = 5; 
    //     long q = 11; 
    //     // ... (generate keys based on your functions)
    //
    //     string originalMessage = "Hello, world!";
    //
    //     var encrypted = SimpleRSA.Encrypt(key, modulus, originalMessage);
    //     var decrypted = SimpleRSA.Decrypt(key, modulus, encrypted); 
    //
    //     Assert.Equal(originalMessage, decrypted);
    // }
}