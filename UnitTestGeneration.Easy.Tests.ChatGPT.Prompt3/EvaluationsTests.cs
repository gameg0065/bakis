using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class EvaluationsTests
{
    [Theory]
    [InlineData("2+2", 4)] // Valid expression
    [InlineData("3*5", 15)] // Valid expression
    [InlineData("10/2", 5)] // Valid expression
    [InlineData("3*5+7", 22)] // Valid expression
    [InlineData("10/(2+3)", 2)] // Valid expression
    public void Evaluate_ShouldReturnCorrectResult_ForValidExpression(string expression, decimal expectedResult)
    {
        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData("2++2")] // Invalid expression
    [InlineData("3*(5+")] // Invalid expression
    [InlineData("10/0")] // Invalid expression (division by zero)
    public void Evaluate_ShouldReturnZero_ForInvalidExpression(string expression)
    {
        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(decimal.Zero, result);
    }

    [Fact]
    public void Evaluate_ShouldReturnZero_ForEmptyExpression()
    {
        // Arrange
        string expression = "";

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(decimal.Zero, result);
    }
}