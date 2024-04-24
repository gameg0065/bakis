using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class PostfixEvaluationTests
{
    [Fact]
    public void EvaluatePostfix_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "2", "3", "+", "4", "×" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("20", result);
    }

    [Fact]
    public void EvaluatePostfix_InvalidInput_ReturnsExpectedResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "2", "3", "!", "4", "×" }; // Invalid operator

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("-987656789", result);
    }

    [Fact]
    public void EvaluatePostfix_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string>();

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void EvaluatePostfix_InsufficientOperands_ThrowsException()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "2", "+" };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => postfixEvaluation.EvaluatePostix(postfix));
    }

    [Fact]
    public void EvaluatePostfix_DivideByZero_ThrowsException()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "2", "0", "÷" };

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => postfixEvaluation.EvaluatePostix(postfix));
    }
}