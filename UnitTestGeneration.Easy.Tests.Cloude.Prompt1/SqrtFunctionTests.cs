using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class SqrtFunctionTests
{
    [Fact]
    public void Sqrt_PerfectSquare_ReturnsExactResult()
    {
        // Arrange
        decimal input = 25;
        decimal expected = 5;

        // Act
        decimal result = SqrtFunction.Sqrt(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sqrt_NonPerfectSquare_ReturnsApproximateResult()
    {
        // Arrange
        decimal input = 2;
        decimal expected = 1.414213562373095M; // Square root of 2 with 15 decimal places
        decimal epsilon = 0.0000000000000001M; // Acceptable error margin

        // Act
        decimal result = SqrtFunction.Sqrt(input, epsilon);

        // Assert
        Assert.InRange(result, expected - epsilon, expected + epsilon);
    }

    [Fact]
    public void Sqrt_NegativeNumber_ThrowsOverflowException()
    {
        // Arrange
        decimal input = -1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(input));
    }

    [Fact]
    public void Sqrt_Zero_ReturnsZero()
    {
        // Arrange
        decimal input = 0;
        decimal expected = 0;

        // Act
        decimal result = SqrtFunction.Sqrt(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sqrt_LargeNumber_ReturnsApproximateResult()
    {
        // Arrange
        decimal input = 1000000000000;
        decimal expected = 1000000M; // Square root of 1,000,000,000,000 with 6 decimal places
        decimal epsilon = 0.00001M; // Acceptable error margin

        // Act
        decimal result = SqrtFunction.Sqrt(input, epsilon);

        // Assert
        Assert.InRange(result, expected - epsilon, expected + epsilon);
    }
}