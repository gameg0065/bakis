using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class SqrtFunctionTests
{
    [Fact]
    public void Sqrt_NegativeNumber_ThrowsOverflowException()
    {
        // Arrange
        decimal x = -1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(x));
    }

    [Fact]
    public void Sqrt_Zero_ReturnsZero()
    {
        // Arrange
        decimal x = 0;

        // Act
        decimal result = SqrtFunction.Sqrt(x);

        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(1, 0.0000001M, 1)]
    [InlineData(4, 0.000001M, 2)]
    [InlineData(9, 0.0001M, 3)]
    [InlineData(16, 0.001M, 4)]
    [InlineData(25, 0.01M, 5)]
    public void Sqrt_PerfectSquares_ReturnsCorrectResult(decimal x, decimal epsilon, decimal expected)
    {
        // Act
        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 0.000001M, 1.4142135623730951M)]
    [InlineData(3, 0.000001M, 1.7320508075688772M)]
    [InlineData(5, 0.000001M, 2.23606797749979M)]
    [InlineData(7, 0.000001M, 2.6457513110645907M)]
    public void Sqrt_NonPerfectSquares_ReturnsCorrectResult(decimal x, decimal epsilon, decimal expected)
    {
        // Act
        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Assert
        Assert.Equal(expected, result, 7);
    }

    [Theory]
    [InlineData(1, 0.0000001M)]
    [InlineData(4, 0.000001M)]
    [InlineData(9, 0.0001M)]
    [InlineData(16, 0.001M)]
    [InlineData(25, 0.01M)]
    public void Sqrt_PerfectSquares_WithEpsilon_ReturnsCorrectResult(decimal x, decimal epsilon)
    {
        // Act
        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Assert
        Assert.Equal((decimal)Math.Sqrt((double)x), result);
    }
}