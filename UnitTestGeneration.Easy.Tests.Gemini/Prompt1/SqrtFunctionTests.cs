using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class SqrtFunctionTests
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(9, 3)]
    [InlineData(25, 5)]
    public void PerfectSquares_CalculateCorrectly(decimal x, decimal expected)
    {
        decimal result = SqrtFunction.Sqrt(x);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 1.414)] // Approximate value with some precision
    [InlineData(8, 2.828)]
    public void NonPerfectSquares_CalculateWithPrecision(decimal x, decimal expected)
    {
        decimal result = SqrtFunction.Sqrt(x, 0.001M); // Set epsilon for desired precision
        Assert.InRange(result, expected - 0.001M, expected + 0.001M); 
    }

    [Fact]
    public void Zero_ReturnsZero()
    {
        decimal result = SqrtFunction.Sqrt(0);
        Assert.Equal(0, result);
    }

    [Fact]
    public void NegativeNumber_ThrowsOverflowException()
    {
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(-1));
    }
}