using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class PrimeNumersTests
{
    [Theory]
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
    [InlineData(11, true)]
    [InlineData(12, false)]
    [InlineData(13, true)]
    [InlineData(14, false)]
    [InlineData(15, false)]
    public void PrimeTest_ValidInput_ReturnsExpected(int numberToCheck, bool expected)
    {
        // Act
        var result = PrimeNumbers.PrimeTest(numberToCheck);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
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
    [InlineData(11, true)]
    [InlineData(12, false)]
    [InlineData(13, true)]
    [InlineData(14, false)]
    [InlineData(15, false)]
    public void IsNumberPrime_ValidInput_ReturnsExpected(int numberToCheck, bool expected)
    {
        // Act
        var result = PrimeNumbers.IsNumberPrime(numberToCheck);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, true)]
    [InlineData(1, false)]
    [InlineData(2, true)]
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
    [InlineData(14, true)]
    [InlineData(15, false)]
    public void IsNumberEven_ValidInput_ReturnsExpected(int numberToCheck, bool expected)
    {
        // Act
        var result = PrimeNumbers.IsNumberEven(numberToCheck);

        // Assert
        Assert.Equal(expected, result);
    }
}