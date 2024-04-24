using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class PostfixEvaluationTests
{
[Fact]
    public void EvaluatePostfix_EmptyExpression_ReturnsZero()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string>();

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("0", result);
    }

    [Fact]
    public void EvaluatePostfix_SingleValue_ReturnsValue()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "42" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("42", result);
    }

    [Fact]
    public void EvaluatePostfix_Addition_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "3", "4", "+" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("7", result);
    }

    [Fact]
    public void EvaluatePostfix_Subtraction_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "7", "3", "-" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("4", result);
    }

    [Fact]
    public void EvaluatePostfix_Multiplication_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "3", "4", "×" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("12", result);
    }

    [Fact]
    public void EvaluatePostfix_Division_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "12", "4", "÷" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("3", result);
    }

    [Fact]
    public void EvaluatePostfix_Power_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "2", "3", "^" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("8", result);
    }

    [Fact]
    public void EvaluatePostfix_ComplexExpression_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "5", "3", "+", "7", "÷", "2", "^" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("16", result);
    }

    [Fact]
    public void EvaluatePostfix_InvalidOperator_ReturnsErrorValue()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "3", "4", "%" };

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfix);

        // Assert
        Assert.Equal("-987656789", result);
    }

    [Fact]
    public void EvaluatePostfix_DivisionByZero_ThrowsException()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfix = new List<string> { "5", "0", "÷" };

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => postfixEvaluation.EvaluatePostix(postfix));
    }
}