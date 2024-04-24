using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class EvaluationsTests
{
    [Fact]
    public void Evaluate_ValidExpression_ReturnsCorrectResult()
    {
        // Arrange
        string expression = "2 + 3";
        decimal expected = 5;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_ExpressionWithDecimal_ReturnsCorrectResult()
    {
        // Arrange
        string expression = "2.5 * 4";
        decimal expected = 10;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_ExpressionWithMultipleOperations_ReturnsCorrectResult()
    {
        // Arrange
        string expression = "2 + 3 * 4 - 1";
        decimal expected = 13;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_ExpressionWithParentheses_ReturnsCorrectResult()
    {
        // Arrange
        string expression = "(2 + 3) * 4";
        decimal expected = 20;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_InvalidExpression_ReturnsZero()
    {
        // Arrange
        string expression = "2 + abc";

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(0m, result);
    }

    [Fact]
    public void Evaluate_EmptyExpression_ReturnsZero()
    {
        // Arrange
        string expression = string.Empty;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(0m, result);
    }

    [Fact]
    public void Evaluate_NullExpression_ReturnsZero()
    {
        // Arrange
        string expression = null;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(0m, result);
    }
}