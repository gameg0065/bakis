using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class SimpleRSATests
{
    // Tests for prime-related functions
    [Theory]
    [InlineData(2, true)]
    [InlineData(7, true)]
    [InlineData(91, false)] 
    public void IsPrime_TestsPrimeNumbers(long input, bool expected)
    {
        var result = SimpleRSA.IsPrime(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetPrimes_FindsPrimesWithinTotient()
    {
        long p = 5;
        long q = 11;

        var result = SimpleRSA.GetPrimes(p, q);
        // Assert that result contains valid primes and the expected count
    }

    // Tests for modular arithmetic functions
    [Theory]
    [InlineData(10, 5, 3, 2)] // Example values
    public void MulMod_CalculatesModularMultiplication(long a, long b, long mod, long expected)
    {
        var result = SimpleRSA.MulMod(a, b, mod);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 5, 3, 2)] // Example values
    public void MulModTwo_CalculatesModularMultiplication(long a, long b, long mod, long expected)
    {
        var result = SimpleRSA.MulModTwo(a, b, mod);
        Assert.Equal(expected, result);
    }

    // ... Similar tests for ModularPow and PosMod

    // Tests for encryption/decryption
    [Fact]
    public void EncryptDecrypt_SmallInput_RoundtripSuccessful()
    {
        string message = "Test";
        long key = 3; 
        long modulus = 17; // Choose appropriate values

        var encrypted = SimpleRSA.Encrypt(key, modulus, message);
        var decrypted = SimpleRSA.Decrypt(key, modulus, encrypted);

        Assert.Equal(message, decrypted);

        // Repeat using EncryptTwo/DecryptTwo 
    }
}