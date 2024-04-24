using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class PrimeNumbersTests
{
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
    [InlineData(11, true)]
    [InlineData(12, false)]
    [InlineData(13, true)]
    [InlineData(0, false)]
    [InlineData(-1, false)]
    [InlineData(int.MaxValue, true)]
    public void PrimeTest_ShouldReturnCorrectResult(int number, bool expected)
    {
        // Act
        bool actual = PrimeNumbers.PrimeTest(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, false)]
    [InlineData(3, false)]
    [InlineData(4, true)]
    [InlineData(5, false)]
    [InlineData(6, true)]
    [InlineData(7, false)]
    [InlineData(8, true)]
    [InlineData(9, false)]
    [InlineData(10, true)]
    [InlineData(11, false)]
    [InlineData(12, true)]
    [InlineData(13, false)]
    [InlineData(0, true)]
    [InlineData(-1, false)]
    [InlineData(int.MaxValue, false)]
    public void IsNumberEven_ShouldReturnCorrectResult(int number, bool expected)
    {
        // Act
        bool actual = PrimeNumbers.IsNumberEven(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 3, false)]
    [InlineData(3, 3, true)]
    [InlineData(4, 3, false)]
    [InlineData(5, 3, false)]
    [InlineData(6, 3, true)]
    [InlineData(7, 3, false)]
    [InlineData(8, 3, false)]
    [InlineData(9, 3, true)]
    [InlineData(10, 3, false)]
    [InlineData(11, 3, false)]
    [InlineData(12, 3, true)]
    [InlineData(13, 3, false)]
    [InlineData(0, 3, true)]
    [InlineData(-1, 3, false)]
    [InlineData(int.MaxValue, 3, false)]
    public void IsNumberPrime_ShouldReturnCorrectResult(int number, int potentialDivider, bool expected)
    {
        // Act
        bool actual = PrimeNumbers.IsNumberPrime(number, potentialDivider);

        // Assert
        Assert.Equal(expected, actual);
    }
}