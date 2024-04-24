using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class InfixToPostfixAppTests
{
    private readonly InfixToPostfixApp _app;

    public InfixToPostfixAppTests()
    {
        _app = new InfixToPostfixApp();
    }

    [Fact]
    public void InfixToPostfix_SingleNumber_ReturnsNumberAsPostfix()
    {
        // Arrange
        string infix = "42";

        // Act
        List<string> postfix = _app.InfixToPostfix(infix);

        // Assert
        Assert.Single(postfix);
        Assert.Equal("42", postfix[0]);
    }

    [Fact]
    public void InfixToPostfix_SimpleExpression_ReturnsCorrectPostfix()
    {
        // Arrange
        string infix = "2 + 3";

        // Act
        List<string> postfix = _app.InfixToPostfix(infix);

        // Assert
        Assert.Equal(new[] { "2", "3", "+" }, postfix);
    }

    [Fact]
    public void InfixToPostfix_ComplexExpression_ReturnsCorrectPostfix()
    {
        // Arrange
        string infix = "2 + 3 * 4 - 5 / 6 ^ 2 ^ 3";

        // Act
        List<string> postfix = _app.InfixToPostfix(infix);

        // Assert
        Assert.Equal(new[] { "2", "3", "4", "×", "+", "5", "6", "2", "3", "^", "^", "÷", "-" }, postfix);
    }

    [Fact]
    public void InfixToPostfix_ExpressionWithParentheses_ReturnsCorrectPostfix()
    {
        // Arrange
        string infix = "(2 + 3) * 4 - (5 / 6) ^ (2 ^ 3)";

        // Act
        List<string> postfix = _app.InfixToPostfix(infix);

        // Assert
        Assert.Equal(new[] { "2", "3", "+", "4", "×", "5", "6", "÷", "2", "3", "^", "^", "-" }, postfix);
    }

    [Fact]
    public void InfixToPostfix_EmptyInfix_ReturnsEmptyPostfix()
    {
        // Arrange
        string infix = "";

        // Act
        List<string> postfix = _app.InfixToPostfix(infix);

        // Assert
        Assert.Empty(postfix);
    }

    [Fact]
    public void InfixToPostfix_InvalidExpression_ThrowsException()
    {
        // Arrange
        string infix = "2 + 3 )";

        // Act & Assert
        Assert.Throws<System.Exception>(() => _app.InfixToPostfix(infix));
    }
}