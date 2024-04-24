using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class EvaluationsTests
{
    [Fact]
    public void Evaluate_SimpleAddition_ReturnsCorrectResult()
    {
        // Arrange
        string expression = "2+3";
        decimal expected = 5;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_SimpleMultiplication_ReturnsCorrectResult()
    {
        // Arrange
        string expression = "4*5";
        decimal expected = 20;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_ComplexExpression_ReturnsCorrectResult()
    {
        // Arrange
        string expression = "(2+3)*4-1";
        decimal expected = 19;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_ExpressionWithDecimals_ReturnsCorrectResult()
    {
        // Arrange
        string expression = "3.14*2";
        decimal expected = 6.28m;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_InvalidExpression_ReturnsZero()
    {
        // Arrange
        string expression = "2+";
        decimal expected = 0;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Evaluate_EmptyExpression_ReturnsZero()
    {
        // Arrange
        string expression = "";
        decimal expected = 0;

        // Act
        decimal result = Evaluations.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result);
    }
}