using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class InfixToPostfixAppTests
{
    private readonly InfixToPostfixApp _app;

    public InfixToPostfixAppTests()
    {
        _app = new InfixToPostfixApp();
    }

    [Theory]
    [InlineData("2 + 3", new[] { "2", "3", "+" })]
    [InlineData("2 * 3 + 4", new[] { "2", "3", "*", "4", "+" })]
    [InlineData("2 * (3 + 4)", new[] { "2", "3", "4", "+", "*" })]
    [InlineData("(2 + 3) * 4", new[] { "2", "3", "+", "4", "*" })]
    [InlineData("2 ^ 3 ^ 4", new[] { "2", "3", "4", "^", "^" })]
    [InlineData("2 * 3 + 4 * 5", new[] { "2", "3", "*", "4", "5", "*", "+" })]
    [InlineData("(2 + 3) * (4 + 5)", new[] { "2", "3", "+", "4", "5", "+", "*" })]
    public void InfixToPostfix_ReturnsCorrectPostfixExpression(string infix, string[] expected)
    {
        // Act
        List<string> actual = _app.InfixToPostfix(infix);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void InfixToPostfix_HandlesInvalidInput()
    {
        // Arrange
        string infix = "2 + 3 ) (";

        // Act & Assert
        Assert.Throws<System.InvalidOperationException>(() => _app.InfixToPostfix(infix));
    }
}