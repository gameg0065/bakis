using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class VisualCalculatorTests
{
    [Fact]
    public void BtnEnter_Click_NoneOperation_ReturnsZero()
    {
        var result = VisualCalculator.BtnEnter_Click(5, 8, VisualCalculator.Calculator_Opertaions.none);
        Assert.Equal(0, result);
    }

    [Fact]
    public void BtnEnter_Click_Addition_ReturnsCorrectResult()
    {
        var result = VisualCalculator.BtnEnter_Click(12, 5, VisualCalculator.Calculator_Opertaions.add);
        Assert.Equal(17, result);
    }


    [Fact]
    public void BtnEnter_Click_Subtraction_ReturnsCorrectResult()
    {
        var result = VisualCalculator.BtnEnter_Click(10, 3, VisualCalculator.Calculator_Opertaions.subtract);
        Assert.Equal(7, result);
    }

    [Fact]
    public void BtnEnter_Click_Multiplication_ReturnsCorrectResult()
    {
        var result = VisualCalculator.BtnEnter_Click(5, 6, VisualCalculator.Calculator_Opertaions.multiplicate);
        Assert.Equal(30, result);
    }
    
    [Fact]
    public void BtnEnter_Click_Division_ReturnsCorrectResult()
    {
        var result = VisualCalculator.BtnEnter_Click(25, 5, VisualCalculator.Calculator_Opertaions.divide);
        Assert.Equal(5, result);
    }

}