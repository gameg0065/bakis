using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class VisualCalculatorTests
{
    [Theory]
    [InlineData(10.0, 5.0, VisualCalculator.Calculator_Opertaions.add, 15.0)]
    [InlineData(-2.5, 3.7, VisualCalculator.Calculator_Opertaions.add, 1.2)]
    [InlineData(0.0, 0.0, VisualCalculator.Calculator_Opertaions.add, 0.0)]
    public void BtnEnter_Click_ShouldAddNumbers(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10.0, 5.0, VisualCalculator.Calculator_Opertaions.subtract, 5.0)]
    [InlineData(-2.5, 3.7, VisualCalculator.Calculator_Opertaions.subtract, -6.2)]
    [InlineData(0.0, 0.0, VisualCalculator.Calculator_Opertaions.subtract, 0.0)]
    public void BtnEnter_Click_ShouldSubtractNumbers(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10.0, 5.0, VisualCalculator.Calculator_Opertaions.multiplicate, 50.0)]
    [InlineData(-2.5, 3.7, VisualCalculator.Calculator_Opertaions.multiplicate, -9.25)]
    [InlineData(0.0, 0.0, VisualCalculator.Calculator_Opertaions.multiplicate, 0.0)]
    public void BtnEnter_Click_ShouldMultiplicateNumbers(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10.0, 5.0, VisualCalculator.Calculator_Opertaions.divide, 2.0)]
    [InlineData(-2.5, 3.7, VisualCalculator.Calculator_Opertaions.divide, -0.67567567567567568)]
    [InlineData(0.0, 5.0, VisualCalculator.Calculator_Opertaions.divide, 0.0)]
    public void BtnEnter_Click_ShouldDivideNumbers(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BtnEnter_Click_ShouldReturnZeroForInvalidOperation()
    {
        // Arrange
        double num1 = 10.0;
        double num2 = 5.0;
        VisualCalculator.Calculator_Opertaions operation = (VisualCalculator.Calculator_Opertaions)(-2); // Invalid operation

        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(0.0, result);
    }

    [Theory]
    [InlineData(10.0, 0.0, VisualCalculator.Calculator_Opertaions.divide, double.PositiveInfinity)]
    [InlineData(-10.0, 0.0, VisualCalculator.Calculator_Opertaions.divide, double.NegativeInfinity)]
    public void BtnEnter_Click_ShouldHandleDivisionByZero(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }
}