using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class PrimeNumersTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(5, true)]
    [InlineData(7, true)]
    [InlineData(11, true)]
    [InlineData(13, true)]
    [InlineData(4, false)]
    [InlineData(6, false)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    [InlineData(12, false)]
    [InlineData(15, false)]
    [InlineData(20, false)]
    public void PrimeTest_ReturnsExpectedResult(int numberToCheck, bool expectedResult)
    {
        // Act
        bool result = PrimeNumers.PrimeTest(numberToCheck);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(5, true)]
    [InlineData(7, true)]
    [InlineData(11, true)]
    [InlineData(13, true)]
    [InlineData(4, false)]
    [InlineData(6, false)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    [InlineData(12, false)]
    [InlineData(15, false)]
    [InlineData(20, false)]
    public void IsNumberPrime_ReturnsExpectedResult(int numberToCheck, bool expectedResult)
    {
        // Act
        bool result = PrimeNumers.IsNumberPrime(numberToCheck);

        // Assert
        Assert.Equal(expectedResult, result);
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
    public void IsNumberEven_ReturnsExpectedResult(int numberToCheck, bool expectedResult)
    {
        // Act
        bool result = PrimeNumers.IsNumberEven(numberToCheck);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}