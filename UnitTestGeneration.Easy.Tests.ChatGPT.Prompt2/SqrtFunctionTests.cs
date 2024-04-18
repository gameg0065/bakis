using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class SqrtFunctionTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(4, 2)]
    [InlineData(9, 3)]
    [InlineData(16, 4)]
    public void Sqrt_ShouldReturnCorrectResult_ForPositiveNumbers(decimal x, decimal expected)
    {
        // Act
        decimal result = SqrtFunction.Sqrt(x);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sqrt_ShouldThrowException_ForNegativeNumbers()
    {
        // Arrange
        decimal x = -1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(x));
    }

    [Fact]
    public void Sqrt_ShouldReturnZero_ForZero()
    {
        // Arrange
        decimal x = 0;

        // Act
        decimal result = SqrtFunction.Sqrt(x);

        // Assert
        Assert.Equal(0, result);
    }
}