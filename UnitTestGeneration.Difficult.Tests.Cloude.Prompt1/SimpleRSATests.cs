using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class SimpleRSATests
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void IsPrime_ShouldReturnTrueForPrimeNumbers(long number)
    {
        // Act
        bool result = SimpleRSA.IsPrime(number);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    public void IsPrime_ShouldReturnFalseForNonPrimeNumbers(long number)
    {
        // Act
        bool result = SimpleRSA.IsPrime(number);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(3, 7, true)]
    [InlineData(5, 5, false)]
    [InlineData(4, 6, false)]
    public void CheckPrimes_ShouldReturnCorrectResult(long p, long q, bool expected)
    {
        // Act
        bool result = SimpleRSA.CheckPrimes(p, q);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetEncryptExp_ShouldReturnCorrectEncryptionExponent()
    {
        // Arrange
        long p = 3;
        long q = 11;
        long expected = 7;

        // Act
        long result = SimpleRSA.GetEncryptExp(p, q);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Encrypt_ShouldEncryptMessageCorrectly()
    {
        // Arrange
        long key = 7;
        long modulus = 33;
        string message = "Hello";
        long[] expected = { 104, 102, 116, 116, 111 };

        // Act
        long[] result = SimpleRSA.Encrypt(key, modulus, message);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Decrypt_ShouldDecryptMessageCorrectly()
    {
        // Arrange
        long key = 7;
        long modulus = 33;
        long[] encrypted = { 104, 102, 116, 116, 111 };
        string expected = "Hello";

        // Act
        string result = SimpleRSA.Decrypt(key, modulus, encrypted);

        // Assert
        Assert.Equal(expected, result);
    }
}