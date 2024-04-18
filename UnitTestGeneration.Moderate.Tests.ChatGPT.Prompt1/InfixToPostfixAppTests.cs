using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class InfixToPostfixAppTests
{
    [Fact]
    public void InfixToPostfix_ReturnsCorrectResult_WhenExpressionIsValid()
    {
        // Arrange
        var infixToPostfixApp = new InfixToPostfixApp();
        string infix = "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";

        // Act
        List<string> result = infixToPostfixApp.InfixToPostfix(infix);

        // Assert
        List<string> expected = new List<string> { "3", "4", "2", "*", "1", "5", "-", "2", "3", "^", "^", "/", "+" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_ReturnsCorrectResult_WhenExpressionHasMultipleOperatorsWithSamePrecedence()
    {
        // Arrange
        var infixToPostfixApp = new InfixToPostfixApp();
        string infix = "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3 - 5 + 6";

        // Act
        List<string> result = infixToPostfixApp.InfixToPostfix(infix);

        // Assert
        List<string> expected = new List<string> { "3", "4", "2", "*", "1", "5", "-", "2", "3", "^", "^", "/", "+", "5", "-", "6", "+" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_ReturnsCorrectResult_WhenExpressionHasNoOperators()
    {
        // Arrange
        var infixToPostfixApp = new InfixToPostfixApp();
        string infix = "3";

        // Act
        List<string> result = infixToPostfixApp.InfixToPostfix(infix);

        // Assert
        List<string> expected = new List<string> { "3" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_ReturnsCorrectResult_WhenExpressionHasParentheses()
    {
        // Arrange
        var infixToPostfixApp = new InfixToPostfixApp();
        string infix = "( 3 + 4 ) * 2";

        // Act
        List<string> result = infixToPostfixApp.InfixToPostfix(infix);

        // Assert
        List<string> expected = new List<string> { "3", "4", "+", "2", "*" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_ReturnsCorrectResult_WhenExpressionHasSingleOperator()
    {
        // Arrange
        var infixToPostfixApp = new InfixToPostfixApp();
        string infix = "3 + 4";

        // Act
        List<string> result = infixToPostfixApp.InfixToPostfix(infix);

        // Assert
        List<string> expected = new List<string> { "3", "4", "+" };
        Assert.Equal(expected, result);
    }
}