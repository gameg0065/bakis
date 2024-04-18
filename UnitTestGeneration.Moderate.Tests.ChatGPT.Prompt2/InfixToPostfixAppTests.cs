using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class InfixToPostfixAppTests
{
    [Theory]
    [InlineData("3 + 4", new[] { "3", "4", "+" })]
    [InlineData("5 * 6", new[] { "5", "6", "*" })]
    [InlineData("10 / 2", new[] { "10", "2", "/" })]
    [InlineData("7 - 2", new[] { "7", "2", "-" })]
    public void InfixToPostfix_ConvertsSimpleExpressionsCorrectly(string infix, string[] expectedPostfix)
    {
        // Arrange
        var infixToPostfixApp = new InfixToPostfixApp();

        // Act
        List<string> result = infixToPostfixApp.InfixToPostfix(infix);

        // Assert
        Assert.Equal(expectedPostfix, result);
    }

    [Theory]
    [InlineData("(3 + 4) * 5", new[] { "3", "4", "+", "5", "*" })]
    [InlineData("10 * (2 + 3)", new[] { "10", "2", "3", "+", "*" })]
    [InlineData("10 * (2 + 3) - 4", new[] { "10", "2", "3", "+", "*", "4", "-" })]
    public void InfixToPostfix_ConvertsExpressionsWithParenthesesCorrectly(string infix, string[] expectedPostfix)
    {
        // Arrange
        var infixToPostfixApp = new InfixToPostfixApp();

        // Act
        List<string> result = infixToPostfixApp.InfixToPostfix(infix);

        // Assert
        Assert.Equal(expectedPostfix, result);
    }

    [Theory]
    [InlineData("3 + 4 * 5", new[] { "3", "4", "5", "*", "+" })]
    [InlineData("10 * 2 + 3", new[] { "10", "2", "*", "3", "+" })]
    [InlineData("10 / 2 + 3 * 5", new[] { "10", "2", "/", "3", "5", "*", "+" })]
    public void InfixToPostfix_ConvertsExpressionsWithDifferentPrecedenceCorrectly(string infix, string[] expectedPostfix)
    {
        // Arrange
        var infixToPostfixApp = new InfixToPostfixApp();

        // Act
        List<string> result = infixToPostfixApp.InfixToPostfix(infix);

        // Assert
        Assert.Equal(expectedPostfix, result);
    }
}