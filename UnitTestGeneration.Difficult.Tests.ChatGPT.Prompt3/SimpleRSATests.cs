using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class SimpleRSATests
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
    public void IsPrime_ShouldReturnCorrectly(long n, bool expectedResult)
    {
        // Act
        var result = SimpleRSA.IsPrime(n);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, 3, true)]
    [InlineData(3, 5, true)]
    [InlineData(4, 5, false)]
    [InlineData(5, 7, true)]
    [InlineData(5, 5, false)]
    public void CheckPrimes_ShouldReturnCorrectly(long p, long q, bool expectedResult)
    {
        // Act
        var result = SimpleRSA.CheckPrimes(p, q);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void GetPrimes_ShouldReturnCorrectPrimes()
    {
        // Arrange
        long p = 3, q = 5;

        // Act
        var result = SimpleRSA.GetPrimes(p, q);

        // Assert
        Assert.Equal(new long[] { 2, 3 }, result);
    }
}