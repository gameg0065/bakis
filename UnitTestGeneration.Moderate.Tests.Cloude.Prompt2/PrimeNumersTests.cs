using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class PrimeNumbersTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(4, false)]
    [InlineData(7, true)]
    [InlineData(10, false)]
    public void IsNumberEven_ReturnsCorrectResult(int number, bool expected)
    {
        // Act
        bool result = PrimeNumbers.IsNumberEven(number);

        // Assert
        Assert.Equal(expected, !result);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    public void IsNumberPrime_ReturnsCorrectResult(int number, bool expected)
    {
        // Act
        bool result = PrimeNumbers.IsNumberPrime(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    public void PrimeTest_ReturnsCorrectResult(int number, bool expected)
    {
        // Act
        bool result = PrimeNumbers.PrimeTest(number);

        // Assert
        Assert.Equal(expected, result);
    }
}