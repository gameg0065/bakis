using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class VisualCalculatorTests
{
    [Theory]
    [InlineData(5, 3, VisualCalculator.Calculator_Opertaions.add, 8)]
    [InlineData(10, 2, VisualCalculator.Calculator_Opertaions.subtract, 8)]
    [InlineData(4, 2, VisualCalculator.Calculator_Opertaions.multiplicate, 8)]
    [InlineData(12, 3, VisualCalculator.Calculator_Opertaions.divide, 4)]
    public void BtnEnter_Click_CalculatesCorrectly(double num1, double num2, 
        VisualCalculator.Calculator_Opertaions operation,
        double expectedResult)
    {
        var result = VisualCalculator.BtnEnter_Click(num1, num2, operation);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void BtnEnter_Click_NoneOperation_ReturnsZero()
    {
        var result = VisualCalculator.BtnEnter_Click(5, 10, VisualCalculator.Calculator_Opertaions.none);
        Assert.Equal(0, result);
    }
}