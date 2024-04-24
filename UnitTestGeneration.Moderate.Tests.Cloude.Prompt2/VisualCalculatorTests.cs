using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class VisualCalculatorTests
{
[Theory]
    [InlineData(5.0, 3.0, VisualCalculator.Calculator_Opertaions.add, 8.0)]
    [InlineData(-2.5, 7.8, VisualCalculator.Calculator_Opertaions.add, 5.3)]
    [InlineData(0.0, 0.0, VisualCalculator.Calculator_Opertaions.add, 0.0)]
    public void BtnEnter_Click_ShouldAddTwoNumbers(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10.0, 3.0, VisualCalculator.Calculator_Opertaions.subtract, 7.0)]
    [InlineData(-5.0, -2.0, VisualCalculator.Calculator_Opertaions.subtract, -3.0)]
    [InlineData(0.0, 0.0, VisualCalculator.Calculator_Opertaions.subtract, 0.0)]
    public void BtnEnter_Click_ShouldSubtractTwoNumbers(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(4.0, 3.0, VisualCalculator.Calculator_Opertaions.multiplicate, 12.0)]
    [InlineData(-2.0, 5.0, VisualCalculator.Calculator_Opertaions.multiplicate, -10.0)]
    [InlineData(0.0, 0.0, VisualCalculator.Calculator_Opertaions.multiplicate, 0.0)]
    public void BtnEnter_Click_ShouldMultiplyTwoNumbers(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10.0, 2.0, VisualCalculator.Calculator_Opertaions.divide, 5.0)]
    [InlineData(-6.0, 3.0, VisualCalculator.Calculator_Opertaions.divide, -2.0)]
    [InlineData(0.0, 5.0, VisualCalculator.Calculator_Opertaions.divide, 0.0)]
    public void BtnEnter_Click_ShouldDivideTwoNumbers(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BtnEnter_Click_ShouldReturnZeroForInvalidOperation()
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(5.0, 3.0, (VisualCalculator.Calculator_Opertaions)(-2));

        // Assert
        Assert.Equal(0.0, result);
    }

    [Fact]
    public void BtnEnter_Click_ShouldReturnZeroForNoneOperation()
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(5.0, 3.0, VisualCalculator.Calculator_Opertaions.none);

        // Assert
        Assert.Equal(0.0, result);
    }
}