using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class InfixToPostfixAppTests
{
[Fact]
    public void InfixToPostfix_SingleNumber_ReturnsNumber()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        var infix = "5";

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        var expected = new List<string> { "5" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_SimpleExpression_ConvertsCorrectly()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        var infix = "5 + 3";

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        var expected = new List<string> { "5", "3", "+" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_ComplexExpression_ConvertsCorrectly()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        var infix = "5 * ( 3 + 4 ) / 2 - 1";

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        var expected = new List<string> { "5", "3", "4", "+", "*", "2", "/", "1", "-" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_ExpressionWithParentheses_ConvertsCorrectly()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        var infix = "( 5 + 3 ) * 2";

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        var expected = new List<string> { "5", "3", "+", "2", "*" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_ExpressionWithExponents_ConvertsCorrectly()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        var infix = "3 ^ 2 * 4";

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        var expected = new List<string> { "3", "2", "^", "4", "*" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_EmptyExpression_ReturnsEmptyList()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        var infix = "";

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        var expected = new List<string>();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_InvalidExpression_ThrowsException()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        var infix = "5 + )";

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => app.InfixToPostfix(infix));
    }
}