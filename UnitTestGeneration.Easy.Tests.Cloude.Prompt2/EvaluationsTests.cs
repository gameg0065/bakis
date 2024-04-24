using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class EvaluationsTests
{
    [Theory]
    [InlineData("2+3", 5)]
    [InlineData("10-5", 5)]
    [InlineData("4*6", 24)]
    [InlineData("20/4", 5)]
    public void Evaluate_ValidNumericalExpressions_ReturnsCorrectResult(string expression, decimal expected)
    {
        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("(2+3)*4", 20)]
    [InlineData("(5-2)*3", 9)]
    [InlineData("2*(4+6)", 20)]
    public void Evaluate_ExpressionsWithParentheses_ReturnsCorrectResult(string expression, decimal expected)
    {
        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3.14*2", 6.28m)]
    [InlineData("10/3", 3.33333333333333333333m)]
    public void Evaluate_ExpressionsWithDecimals_ReturnsCorrectResult(string expression, decimal expected)
    {
        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_EmptyString_ReturnsZero()
    {
        // Act
        decimal result = Evaluations.Evaluate("");

        // Assert
        Assert.Equal(0m, result);
    }

    [Theory]
    [InlineData("2+")]
    [InlineData("3*")]
    [InlineData("(4+2")]
    [InlineData("a+b")]
    public void Evaluate_InvalidExpressions_ReturnsZero(string expression)
    {
        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(0m, result);
    }
}