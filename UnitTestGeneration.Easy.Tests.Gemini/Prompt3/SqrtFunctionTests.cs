using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class SqrtFunctionTests
{
    [Fact]
    public void Sqrt_NegativeNumber_ThrowsOverflowException()
    {
        decimal x = -5;
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(x));
    }

    [Fact]
    public void Sqrt_Zero_ReturnsZero()
    {
        decimal x = 0;
        decimal result = SqrtFunction.Sqrt(x);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Sqrt_PerfectSquare_ReturnsExactRoot()
    {
        decimal x = 25;
        decimal result = SqrtFunction.Sqrt(x);
        Assert.Equal(5, result);
    }

    // [Fact]
    // public void Sqrt_NonPerfectSquare_ReturnsApproximateRoot()
    // {
    //     decimal x = 10;
    //     decimal epsilon = 0.01M; // Tolerance for approximation
    //     decimal result = SqrtFunction.Sqrt(x, epsilon);
    //
    //     // Ensure the result is within the specified tolerance 
    //     Assert.InRange(result, Math.Sqrt((double)x) - epsilon, Math.Sqrt((double)x) + epsilon);
    // }
    //
    // [Fact]
    // public void Sqrt_HighPrecision_CalculatesCorrectly()
    // {
    //     decimal x = 2;
    //     decimal epsilon = 0.000000001M; // Smaller epsilon for higher precision
    //     decimal result = SqrtFunction.Sqrt(x, epsilon);
    //
    //     Assert.InRange(result, Math.Sqrt((double)x) - epsilon, Math.Sqrt((double)x) + epsilon);
    // }
}