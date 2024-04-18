using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class SqrtFunctionTests
{
    [Theory]
    [InlineData(0, 0.0)] // Edge case: square root of 0
    [InlineData(1, 0.0)] // Edge case: square root of 1
    [InlineData(4, 0.0)] // Perfect square: square root of 4
    [InlineData(9, 0.0)] // Perfect square: square root of 9
    [InlineData(16, 0.0)] // Perfect square: square root of 16
    [InlineData(25, 0.0)] // Perfect square: square root of 25
    public void Sqrt_ShouldReturnCorrectResult_ForPerfectSquares(decimal x, decimal epsilon)
    {
        // Act
        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Assert
        Assert.Equal((decimal)System.Math.Sqrt((double)x), result); // Expecting result to match system calculation for perfect squares
    }

    [Theory]
    [InlineData(2, 0.1)] // Edge case: square root of 2 with epsilon 0.1
    [InlineData(10, 0.01)] // Edge case: square root of 10 with epsilon 0.01
    [InlineData(100, 0.001)] // Edge case: square root of 100 with epsilon 0.001
    public void Sqrt_ShouldReturnCorrectResult_ForNonPerfectSquares(decimal x, decimal epsilon)
    {
        // Act
        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Assert
        Assert.True(System.Math.Abs((decimal)System.Math.Sqrt((double)x) - result) <= epsilon); // Expecting result to be within epsilon range of system calculation for non-perfect squares
    }

    [Fact]
    public void Sqrt_ShouldThrowOverflowException_ForNegativeInput()
    {
        // Arrange
        decimal x = -1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(x)); // Expecting OverflowException for negative input
    }
}