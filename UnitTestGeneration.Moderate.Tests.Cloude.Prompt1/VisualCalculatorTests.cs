using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class VisualCalculatorTests
{
[Theory]
    [InlineData(10, 5, VisualCalculator.Calculator_Opertaions.add, 15)]
    [InlineData(-8, 3, VisualCalculator.Calculator_Opertaions.add, -5)]
    [InlineData(0, 0, VisualCalculator.Calculator_Opertaions.add, 0)]
    public void AddTest(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 5, VisualCalculator.Calculator_Opertaions.subtract, 5)]
    [InlineData(-8, 3, VisualCalculator.Calculator_Opertaions.subtract, -11)]
    [InlineData(0, 0, VisualCalculator.Calculator_Opertaions.subtract, 0)]
    public void SubtractTest(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 5, VisualCalculator.Calculator_Opertaions.multiplicate, 50)]
    [InlineData(-8, 3, VisualCalculator.Calculator_Opertaions.multiplicate, -24)]
    [InlineData(0, 0, VisualCalculator.Calculator_Opertaions.multiplicate, 0)]
    public void MultiplicateTest(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 5, VisualCalculator.Calculator_Opertaions.divide, 2)]
    [InlineData(-8, 4, VisualCalculator.Calculator_Opertaions.divide, -2)]
    [InlineData(0, 1, VisualCalculator.Calculator_Opertaions.divide, 0)]
    public void DivideTest(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expected)
    {
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InvalidOperationTest()
    {
        double result = VisualCalculator.BtnEnter_Click(10, 5, VisualCalculator.Calculator_Opertaions.none);
        Assert.Equal(0, result);
    }
}