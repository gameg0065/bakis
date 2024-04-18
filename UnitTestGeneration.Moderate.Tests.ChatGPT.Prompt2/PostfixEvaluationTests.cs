using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class PostfixEvaluationTests
{
    [Theory]
    [InlineData(new[] { "2", "3", "+" }, "5")]
    [InlineData(new[] { "4", "2", "-" }, "2")]
    [InlineData(new[] { "5", "2", "×" }, "10")]
    [InlineData(new[] { "6", "3", "÷" }, "2")]
    [InlineData(new[] { "2", "3", "+", "4", "2", "-", "5", "2", "×", "6", "3", "÷" }, "2")]
    public void EvaluatePostfix_ReturnsCorrectResult_ForValidExpressions(string[] postfix, string expected)
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();

        // Act
        string result = postfixEvaluation.EvaluatePostix(new List<string>(postfix));

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void EvaluatePostfix_ReturnsCorrectResult_ForExpressionWithNegativeOperands()
    {
        // Arrange
        var postfix = new[] { "-2", "3", "+" };
        var expected = "1";
        var postfixEvaluation = new PostfixEvaluation();

        // Act
        string result = postfixEvaluation.EvaluatePostix(new List<string>(postfix));

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void EvaluatePostfix_ThrowsException_ForDivisionByZero()
    {
        // Arrange
        var postfix = new[] { "5", "0", "÷" };
        var postfixEvaluation = new PostfixEvaluation();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => postfixEvaluation.EvaluatePostix(new List<string>(postfix)));
    }

    [Fact]
    public void EvaluatePostfix_ThrowsException_ForInvalidExpression()
    {
        // Arrange
        var postfix = new[] { "5", "3", "+", "×" };
        var postfixEvaluation = new PostfixEvaluation();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => postfixEvaluation.EvaluatePostix(new List<string>(postfix)));
    }
}