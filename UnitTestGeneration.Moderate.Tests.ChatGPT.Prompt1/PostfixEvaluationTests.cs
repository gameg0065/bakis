using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class PostfixEvaluationTests
{
    [Fact]
    public void EvaluatePostix_ReturnsCorrectResult_WhenExpressionIsValid()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        List<string> postfix = new List<string> { "5", "2", "+", "3", "*" };

        // Act
        string result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("21", result);
    }

    [Fact]
    public void EvaluatePostix_ReturnsCorrectResult_WhenExpressionHasDecimals()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        List<string> postfix = new List<string> { "3", "3", "/", "2", "*" };

        // Act
        string result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("2.0", result);
    }

    [Fact]
    public void EvaluatePostix_ReturnsCorrectResult_WhenExpressionHasNegativeNumbers()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        List<string> postfix = new List<string> { "-5", "-3", "+" };

        // Act
        string result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("-8", result);
    }

    [Fact]
    public void EvaluatePostix_ReturnsCorrectResult_WhenExpressionHasLargeNumbers()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        List<string> postfix = new List<string> { "999999999", "999999999", "+" };

        // Act
        string result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("1999999998", result);
    }

    [Fact]
    public void EvaluatePostix_ReturnsCorrectResult_WhenExpressionHasZeroDivision()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        List<string> postfix = new List<string> { "5", "0", "/" };

        // Act
        string result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("Infinity", result);
    }
}