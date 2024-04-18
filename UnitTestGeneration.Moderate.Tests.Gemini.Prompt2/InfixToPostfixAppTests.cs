using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class InfixToPostfixAppTests
{
    [Fact]
    public void InfixToPostfix_EmptyInput_ReturnsEmptyList()
    {
        var converter = new InfixToPostfixApp();
        var result = converter.InfixToPostfix("");
        Assert.Empty(result);
    }
    [Fact]
    public void InfixToPostfix_SimpleExpression_ReturnsCorrectPostfix()
    {
        var converter = new InfixToPostfixApp();
        var result = converter.InfixToPostfix("2 + 3");
        Assert.Equal(new List<string> { "2", "3", "+" }, result);
    }
    [Fact]
    public void InfixToPostfix_Precedence_ReturnsCorrectPostfix()
    {
        var converter = new InfixToPostfixApp();
        var result = converter.InfixToPostfix("3 + 4 * 2"); 
        Assert.Equal(new List<string> { "3", "4", "2", "*", "+" }, result);
    }
    [Fact]
    public void InfixToPostfix_Parentheses_ReturnsCorrectPostfix()
    {
        var converter = new InfixToPostfixApp();
        var result = converter.InfixToPostfix("( 3 + 4 ) * 2");
        Assert.Equal(new List<string> { "3", "4", "+", "2", "*" }, result);
    }
    [Fact]
    public void InfixToPostfix_RightAssociativeOperator_ReturnsCorrectPostfix()
    {
        var converter = new InfixToPostfixApp();
        var result = converter.InfixToPostfix("2 ^ 3 ^ 2"); 
        Assert.Equal(new List<string> { "2", "3", "2", "^", "^" }, result);
    }
}