using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class EvaluationsTests
{
    [Fact]
    public void Evaluate_ShouldReturnCorrectResult_ForValidExpression()
    {
        // Arrange
        string validExpression = "2+2";

        // Act
        decimal result = Evaluations.Evaluate(validExpression);

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void Evaluate_ShouldReturnZero_ForInvalidExpression()
    {
        // Arrange
        string invalidExpression = "2a+3b";

        // Act
        decimal result = Evaluations.Evaluate(invalidExpression);

        // Assert
        Assert.Equal(decimal.Zero, result);
    }

    [Fact]
    public void Evaluate_ShouldHandleEmptyExpression()
    {
        // Arrange
        string emptyExpression = "";

        // Act
        decimal result = Evaluations.Evaluate(emptyExpression);

        // Assert
        Assert.Equal(decimal.Zero, result);
    }

    [Fact]
    public void Evaluate_ShouldHandleNullException()
    {
        // Arrange
        string nullExpression = null;

        // Act
        decimal result = Evaluations.Evaluate(nullExpression);

        // Assert
        Assert.Equal(decimal.Zero, result);
    }
}