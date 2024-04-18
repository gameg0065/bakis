using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class InfixToPostfixAppTests
{
    [Theory]
    [InlineData("3 + 4 * 2", new[] { "3", "4", "2", "*", "+" })]
    [InlineData("((5 * 2) / 4) + 3", new[] { "5", "2", "*", "4", "/", "3", "+" })]
    [InlineData("5 + 2 * 3 ^ 2", new[] { "5", "2", "3", "2", "^", "*", "+" })]
    public void InfixToPostfix_ValidInput_ReturnsExpectedResult(string infix, string[] expected)
    {
        // Arrange
        var app = new InfixToPostfixApp();

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3 + (4 * 2)", new[] { "3", "4", "2", "*", "+" })]
    [InlineData("(5 + 2) * 3", new[] { "5", "2", "+", "3", "*" })]
    [InlineData("5 + 2 * (3 + 2)", new[] { "5", "2", "3", "2", "+", "*", "+" })]
    public void InfixToPostfix_ValidInputWithParentheses_ReturnsExpectedResult(string infix, string[] expected)
    {
        // Arrange
        var app = new InfixToPostfixApp();

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InfixToPostfix_EmptyInput_ReturnsEmptyList()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        string infix = "";

        // Act
        var result = app.InfixToPostfix(infix);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void InfixToPostfix_NullInput_ThrowsArgumentNullException()
    {
        // Arrange
        var app = new InfixToPostfixApp();
        string infix = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => app.InfixToPostfix(infix));
    }
}