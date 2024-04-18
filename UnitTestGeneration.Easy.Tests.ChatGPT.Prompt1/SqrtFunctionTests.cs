using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class SqrtFunctionTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(4, 2)]
    [InlineData(9, 3)]
    [InlineData(16, 4)]
    public void Sqrt_ShouldReturnCorrectResult_ForValidInput(decimal input, decimal expected)
    {
        // Act
        decimal result = SqrtFunction.Sqrt(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sqrt_ShouldThrowException_ForNegativeInput()
    {
        // Arrange
        decimal negativeInput = -1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(negativeInput));
    }

    [Theory]
    [InlineData(25, 4, 0.1)]
    [InlineData(36, 6, 0.001)]
    [InlineData(49, 7, 0.00001)]
    public void Sqrt_ShouldReturnCorrectResult_WithCustomEpsilon(decimal input, decimal expected, decimal epsilon)
    {
        // Act
        decimal result = SqrtFunction.Sqrt(input, epsilon);

        // Assert
        Assert.Equal(expected, result);
    }
}