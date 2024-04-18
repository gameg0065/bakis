using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class EvaluationsTests
{
    [Theory]
    [InlineData("2 + 3", 5)]
    [InlineData("10 - 4", 6)]
    [InlineData("5 * 2", 10)]
    [InlineData("20 / 4", 5)]
    public void BasicOperations_EvaluateCorrectly(string expression, decimal expected)
    {
        decimal result = Evaluations.Evaluate(expression);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("2 + 3 * 4", 14)] // Order of operations
    [InlineData("(5 + 5) / 2", 5)]  // Parentheses
    public void ComplexExpressions_EvaluateCorrectly(string expression, decimal expected)
    {
        // ...
    }

    [Fact]
    public void InvalidExpression_ReturnsZero()
    {
        string expression = "5 + / 2"; // Invalid expression
        decimal result = Evaluations.Evaluate(expression);
        Assert.Equal(0, result);
    }
}