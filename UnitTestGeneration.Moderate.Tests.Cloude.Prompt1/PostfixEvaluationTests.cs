using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class PostfixEvaluationTests
{
    [Fact]
    public void EvaluatePostfix_ValidExpression_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfixExpression = new List<string> { "2", "3", "+", "4", "×" };
        var expectedResult = "20";

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfixExpression);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void EvaluatePostfix_ExpressionWithDivision_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfixExpression = new List<string> { "10", "5", "÷", "2", "×" };
        var expectedResult = "4";

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfixExpression);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void EvaluatePostfix_ExpressionWithExponentiation_ReturnsCorrectResult()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfixExpression = new List<string> { "2", "3", "^" };
        var expectedResult = "8";

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfixExpression);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void EvaluatePostfix_InvalidExpression_ReturnsDefaultValue()
    {
        // Arrange
        var postfixEvaluation = new PostfixEvaluation();
        var postfixExpression = new List<string> { "2", "3", "!", "4", "×" };
        var expectedResult = "-987656789";

        // Act
        var result = postfixEvaluation.EvaluatePostix(postfixExpression);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}