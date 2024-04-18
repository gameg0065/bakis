using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class PrimeNumersTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(4, true)]
    [InlineData(5, false)]
    [InlineData(6, true)]
    [InlineData(7, false)]
    public void IsNumberEven_ReturnsExpectedResult(int numberToCheck, bool expected)
    {
        // Act
        bool result = PrimeNumbers.IsNumberEven(numberToCheck);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    public void IsNumberPrime_ReturnsExpectedResult(int numberToCheck, bool expected)
    {
        // Act
        bool result = PrimeNumbers.IsNumberPrime(numberToCheck);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-1, false)]
    [InlineData(0, false)]
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
    public void PrimeTest_ReturnsExpectedResult(int numberToCheck, bool expected)
    {
        // Act
        bool result = PrimeNumbers.PrimeTest(numberToCheck);

        // Assert
        Assert.Equal(expected, result);
    }
}