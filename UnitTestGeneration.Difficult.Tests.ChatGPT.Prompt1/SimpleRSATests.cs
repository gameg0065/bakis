using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1;

public class SimpleRSATests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(17, true)]
    [InlineData(25, false)]
    public void IsPrime_ShouldReturnCorrectResult(long number, bool expected)
    {
        // Act
        bool result = SimpleRSA.IsPrime(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 7, true)]
    [InlineData(5, 5, false)]
    [InlineData(11, 13, true)]
    [InlineData(17, 19, true)]
    [InlineData(23, 23, false)]
    [InlineData(25, 29, false)]
    public void CheckPrimes_ShouldReturnCorrectResult(long p, long q, bool expected)
    {
        // Act
        bool result = SimpleRSA.CheckPrimes(p, q);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetPrimes_ShouldReturnArrayOfPrimes()
    {
        // Arrange
        long p = 5;
        long q = 7;
        long[] expectedPrimes = { 2, 3 };

        // Act
        long[] result = SimpleRSA.GetPrimes(p, q);

        // Assert
        Assert.Equal(expectedPrimes, result);
    }

    [Fact]
    public void EncryptAndDecrypt_ShouldWorkCorrectly()
    {
        // Arrange
        long p = 5;
        long q = 7;
        long[] primes = SimpleRSA.GetPrimes(p, q);
        long modulus = p * q;
        long publicKey = SimpleRSA.GetEncryptExp(p, q);
        string originalMessage = "Hello";

        // Act
        long[] encrypted = SimpleRSA.Encrypt(publicKey, modulus, originalMessage);
        string decrypted = SimpleRSA.Decrypt(publicKey, modulus, encrypted);

        // Assert
        Assert.Equal(originalMessage, decrypted);
    }
}