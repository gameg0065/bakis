using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class VisualCalculatorTests
{
    [Fact]
    public void BtnEnter_Click_NoneOperation_ReturnsZero()
    {
        // Arrange
        double num1 = 10;
        double num2 = 5;
        VisualCalculator.Calculator_Opertaions operation = VisualCalculator.Calculator_Opertaions.none;
        double expected = 0;

        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, VisualCalculator.Calculator_Opertaions.add, 5)] // Addition
    [InlineData(5, 3, VisualCalculator.Calculator_Opertaions.subtract, 2)] // Subtraction
    [InlineData(2, 3, VisualCalculator.Calculator_Opertaions.multiplicate, 6)] // Multiplication
    [InlineData(10, 2, VisualCalculator.Calculator_Opertaions.divide, 5)] // Division
    public void BtnEnter_Click_Operation_ReturnsExpectedResult(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BtnEnter_Click_InvalidOperation_ReturnsZero()
    {
        // Arrange
        double num1 = 10;
        double num2 = 5;
        VisualCalculator.Calculator_Opertaions operation = (VisualCalculator.Calculator_Opertaions)10; // Invalid operation
        double expected = 0;

        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }
}