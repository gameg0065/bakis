using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class VisualCalculatorTests
{
    [Theory]
    [InlineData(5, 3, VisualCalculator.Calculator_Opertaions.add, 8)]
    [InlineData(5, 3, VisualCalculator.Calculator_Opertaions.subtract, 2)]
    [InlineData(5, 3, VisualCalculator.Calculator_Opertaions.multiplicate, 15)]
    [InlineData(6, 3, VisualCalculator.Calculator_Opertaions.divide, 2)]
    public void BtnEnter_Click_ReturnsExpectedResult(double num1, double num2, VisualCalculator.Calculator_Opertaions operation, double expectedResult)
    {
        // Act
        double result = VisualCalculator.BtnEnter_Click(num1, num2, operation);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}