using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class SqrtFunctionTests
{
    [Fact]
    public void Sqrt_NegativeInput_ThrowsOverflowException()
    {
        // Arrange
        decimal x = -1.0m;

        // Act & Assert
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(x));
    }

    [Fact]
    public void Sqrt_Zero_ReturnsZero()
    {
        // Arrange
        decimal x = 0.0m;

        // Act
        decimal result = SqrtFunction.Sqrt(x);

        // Assert
        Assert.Equal(0.0m, result);
    }

    [Fact]
    public void Sqrt_PositiveInteger_CalculatesCorrectly()
    {
        // Arrange
        decimal x = 25.0m;
        decimal expected = 5.0m;

        // Act
        decimal result = SqrtFunction.Sqrt(x);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sqrt_PositiveDecimal_CalculatesCorrectly()
    {
        // Arrange
        decimal x = 2.25m;
        decimal expected = 1.5m;
        decimal epsilon = 0.0001m;

        // Act
        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Assert
        Assert.Equal(expected, result, 7);
    }

    [Fact]
    public void Sqrt_LargeInput_CalculatesCorrectly()
    {
        // Arrange
        decimal x = 1000000000000.0m;
        decimal expected = 1000000.0m;
        decimal epsilon = 0.000001m;

        // Act
        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Assert
        Assert.Equal(expected, result, 6);
    }

    [Fact]
    public void Sqrt_SmallInput_CalculatesCorrectly()
    {
        // Arrange
        decimal x = 0.0000000000001m;
        decimal expected = 0.000000001m;
        decimal epsilon = 0.0000000000000001m;

        // Act
        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Assert
        Assert.Equal(expected, result, 12);
    }
}