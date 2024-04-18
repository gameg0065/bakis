using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class PostfixEvaluationTests
{
    [Fact]
    public void EvaluatePostfix_SimpleAddition()
    {
        var eval = new PostfixEvaluation();
        var postfix = new List<string> { "2", "3", "+" };

        var result = eval.EvaluatePostix(postfix);

        Assert.Equal("5", result);
    }

    [Fact]
    public void EvaluatePostfix_MultipleOperations()
    {
        var eval = new PostfixEvaluation();
        var postfix = new List<string> { "7", "2", "3", "×", "-" }; 

        var result = eval.EvaluatePostix(postfix);

        Assert.Equal("1", result);
    }

    [Fact]
    public void EvaluatePostfix_WithExponents()
    {
        var eval = new PostfixEvaluation();
        var postfix = new List<string> { "3", "2", "^" }; 

        var result = eval.EvaluatePostix(postfix);

        Assert.Equal("9", result);
    }

    [Fact]
    public void EvaluatePostfix_InvalidExpression()
    {
        var eval = new PostfixEvaluation();
        var postfix = new List<string> { "2", "+" }; // Missing operand

        Assert.Throws<InvalidOperationException>(() => eval.EvaluatePostix(postfix));
    }
}