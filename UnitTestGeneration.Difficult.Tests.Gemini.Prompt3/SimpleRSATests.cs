using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt3;

public class SimpleRSATests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(23, true)]
    [InlineData(1, false)]
    [InlineData(28, false)]
    public void IsPrime_ShouldReturnCorrectResult(long input, bool expected)
    {
        var result = SimpleRSA.IsPrime(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetPrimes_MaxLengthLimit_ShouldWork()
    {
        long p = 5;
        long q = 7;

        var primes = SimpleRSA.GetPrimes(p, q);

        // Ensure the maxLength limit is respected 
        Assert.True(primes.Length <= 40); 
    }

    [Fact]
    public void EncryptDecrypt_BasicString_ShouldWork()
    {
        long p = 11;
        long q = 17;
        long key = 3; 
        long modulus = p * q;
        string originalText = "Secret Message";

        var encrypted = SimpleRSA.Encrypt(key, modulus, originalText);
        var decrypted = SimpleRSA.Decrypt(key, modulus, encrypted);

        Assert.Equal(originalText, decrypted);
    }
}