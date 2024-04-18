using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class InfixToPostfixAppTests
{
    [Fact]
    public void SimpleInfixExpression_ConvertsToPostfix()
    {
        InfixToPostfixApp converter = new InfixToPostfixApp();
        List<string> expected = new List<string> { "3", "5", "+" }; 
        List<string> result = converter.InfixToPostfix("3 + 5");
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ComplexExpression_ConvertsToPostfix()
    {
        InfixToPostfixApp converter = new InfixToPostfixApp();
        List<string> expected = new List<string> { "2", "5", "3", "*", "-" };
        List<string> result = converter.InfixToPostfix("2 - (5 * 3)");
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RightAssociativeOperator_ConvertsToPostfix()
    {
        InfixToPostfixApp converter = new InfixToPostfixApp();
        List<string> expected = new List<string> { "2", "3", "2", "^", "^" };
        List<string> result = converter.InfixToPostfix("2 ^ 3 ^ 2");
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InvalidInfixExpression_ThrowsException()
    {
        InfixToPostfixApp converter = new InfixToPostfixApp();
        Assert.Throws<KeyNotFoundException>(() => converter.InfixToPostfix("5 + $ 2")); 
    }
}