using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class PrimeNumbersTests
{
    [Fact]
    public void IsNumberEven_EvenNumber_ReturnsTrue()
    {
        // Arrange
        int evenNumber = 4;

        // Act
        bool result = PrimeNumbers.IsNumberEven(evenNumber);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNumberEven_OddNumber_ReturnsFalse()
    {
        // Arrange
        int oddNumber = 7;

        // Act
        bool result = PrimeNumbers.IsNumberEven(oddNumber);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumberPrime_PrimeNumber_ReturnsTrue()
    {
        // Arrange
        int primeNumber = 7;

        // Act
        bool result = PrimeNumbers.IsNumberPrime(primeNumber);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNumberPrime_NonPrimeNumber_ReturnsFalse()
    {
        // Arrange
        int nonPrimeNumber = 9;

        // Act
        bool result = PrimeNumbers.IsNumberPrime(nonPrimeNumber);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(0)]
    [InlineData(-5)]
    public void PrimeTest_NumberLessThanOrEqualToOne_ReturnsFalse(int number)
    {
        // Act
        bool result = PrimeNumbers.PrimeTest(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void PrimeTest_PrimeNumber_ReturnsTrue()
    {
        // Arrange
        int primeNumber = 7;

        // Act
        bool result = PrimeNumbers.PrimeTest(primeNumber);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void PrimeTest_NonPrimeNumber_ReturnsFalse()
    {
        // Arrange
        int nonPrimeNumber = 9;

        // Act
        bool result = PrimeNumbers.PrimeTest(nonPrimeNumber);

        // Assert
        Assert.False(result);
    }
}