using System.Data;
using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class EvaluationsTests
{
    [Fact]
    public void Evaluate_SimpleAddition_ReturnsCorrectResult()
    {
        var result = Evaluations.Evaluate("2 + 3");
        Assert.Equal(5m, result);
    }

    [Fact]
    public void Evaluate_SimpleSubtraction_ReturnsCorrectResult()
    {
        var result = Evaluations.Evaluate("10 - 5");
        Assert.Equal(5m, result);
    }

    [Fact]
    public void Evaluate_MultiplicationAndDivision_ReturnsCorrectResult()
    {
        var result = Evaluations.Evaluate("6 * 2 / 3");
        Assert.Equal(4m, result);
    }

    [Fact]
    public void Evaluate_HandlesOrderOfOperations_ReturnsCorrectResult()
    {
        var result = Evaluations.Evaluate("2 + 3 * 4"); // Should be 14
        Assert.Equal(14m, result);
    }

    [Fact]
    public void Evaluate_InvalidExpression_ReturnsZero()
    {
        var result = Evaluations.Evaluate("a + b");
        Assert.Equal(0m, result);
    }

    // Consider adding more tests for decimals, negative numbers, etc.

    // (Optional, if you want to enforce a specific exception type)
    [Fact]
    public void Evaluate_InvalidExpression_ThrowsSpecificException()
    {
        Assert.Throws<SyntaxErrorException>(() => Evaluations.Evaluate("a + b"));
    }
}