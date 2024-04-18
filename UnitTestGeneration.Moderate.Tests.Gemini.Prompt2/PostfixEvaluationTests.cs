using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class PostfixEvaluationTests
{
    [Fact]
    public void EvaluatePostfix_EmptyExpression_ReturnsError()
    {
        var evaluator = new PostfixEvaluation();
        var result = evaluator.EvaluatePostix(new List<string>());
        // Decide how you want to handle empty input (e.g., specific error message)
        Assert.Equal("Invalid Expression", result); 
    }

    [Fact]
    public void EvaluatePostfix_SimpleExpression_ReturnsCorrectResult()
    {
        var evaluator = new PostfixEvaluation();
        var result = evaluator.EvaluatePostix(new List<string> {"10", "2", "+" });
        Assert.Equal("12", result);
    }
    [Fact]
    public void EvaluatePostfix_ComplexExpression_ReturnsCorrectResult()
    {
        var evaluator = new PostfixEvaluation();
        var result = evaluator.EvaluatePostix(new List<string> { "6", "2", "3", "+", "8", "2", "/", "-" , "*" });
        Assert.Equal("3", result);
    }
    [Fact]
    public void EvaluatePostfix_InvalidOperator_HandlesError()
    {
        var evaluator = new PostfixEvaluation();
        var result = evaluator.EvaluatePostix(new List<string> { "7", "2", "%" }); 
        // Decide how to handle invalid input (e.g., a specific error message)
        Assert.Equal("Invalid Operator", result);
    }

}