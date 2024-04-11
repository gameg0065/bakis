using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini;

public class EvaluationsTests
{
    [Fact]
    public void TestSimpleAddition()
    {
        string expression = "2 + 3";
        decimal expected = 5;

        decimal result = Evaluations.Evaluate(expression);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestSimpleSubtraction()
    {
        string expression = "5 - 2";
        decimal expected = 3;

        decimal result = Evaluations.Evaluate(expression);
        Assert.Equal(expected, result);
    }

    // ... Tests for multiplication, division

    [Fact]
    public void TestOrderOfOperations()
    {
        string expression = "2 + 3 * 4";
        decimal expected = 14;

        decimal result = Evaluations.Evaluate(expression);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestInvalidExpression()
    {
        string expression = "2 + x"; 
        decimal expected = 0; // Assuming FormatException behavior

        decimal result = Evaluations.Evaluate(expression);
        Assert.Equal(expected, result);
    }
}