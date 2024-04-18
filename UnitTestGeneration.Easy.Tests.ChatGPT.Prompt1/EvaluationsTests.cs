using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class EvaluationsTests
{
    [Theory]
    [InlineData("2+2", 4)]
    [InlineData("3*5", 15)]
    [InlineData("10/2", 5)]
    public void Evaluate_ShouldEvaluateCorrectly(string expression, decimal expected)
    {
        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_ShouldHandleInvalidExpression_ReturnZero()
    {
        // Arrange
        string invalidExpression = "2a+3b";

        // Act
        decimal result = Evaluations.Evaluate(invalidExpression);

        // Assert
        Assert.Equal(decimal.Zero, result);
    }

    [Fact]
    public void Evaluate_ShouldHandleDivisionByZero_ReturnZero()
    {
        // Arrange
        string divisionByZeroExpression = "10/0";

        // Act
        decimal result = Evaluations.Evaluate(divisionByZeroExpression);

        // Assert
        Assert.Equal(decimal.Zero, result);
    }
}