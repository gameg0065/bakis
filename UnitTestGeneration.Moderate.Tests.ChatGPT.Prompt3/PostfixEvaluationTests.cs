using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class PostfixEvaluationTests
{
    [Fact]
    public void EvaluatePostfix_EmptyList_ReturnsEmptyString()
    {
        // Arrange
        var postfix = new List<string>();

        // Act
        var result = new PostfixEvaluation().EvaluatePostix(postfix);

        // Assert
        Assert.Equal("", result);
    }

    [Theory]
    [InlineData("5", "5")]
    [InlineData("10", "10")]
    [InlineData("2", "2")]
    public void EvaluatePostfix_OnlyOperands_ReturnsOperand(string operand, string expected)
    {
        // Arrange
        var postfix = new List<string> { operand };

        // Act
        var result = new PostfixEvaluation().EvaluatePostix(postfix);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("5 2 +", "7")]
    [InlineData("10 3 -", "7")]
    [InlineData("6 2 ÷", "3")]
    [InlineData("3 2 ×", "6")]
    [InlineData("4 2 ^", "16")]
    public void EvaluatePostfix_Operations_ReturnsExpectedResult(string expression, string expected)
    {
        // Arrange
        var postfix = expression.Split(' ');

        // Act
        var result = new PostfixEvaluation().EvaluatePostix(new List<string>(postfix));

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void EvaluatePostfix_ComplexExpression_ReturnsExpectedResult()
    {
        // Arrange
        var postfix = new List<string> { "5", "10", "3", "×", "+", "6", "2", "÷", "-" };

        // Act
        var result = new PostfixEvaluation().EvaluatePostix(postfix);

        // Assert
        Assert.Equal("13", result);
    }
}