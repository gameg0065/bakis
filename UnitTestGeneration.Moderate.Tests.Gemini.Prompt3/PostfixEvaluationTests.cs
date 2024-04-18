using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class PostfixEvaluationTests
{
    [Fact]
        public void EvaluatePostfix_EmptyExpression_ReturnsErrorValue()
        {
            // Arrange
            var evaluator = new PostfixEvaluation();
            var postfixExpression = new List<string>();

            // Act
            var result = evaluator.EvaluatePostix(postfixExpression);

            // Assert
            Assert.Equal("-987656789", result); // Assuming this is your intended error value
        }

        [Fact]
        public void EvaluatePostfix_SingleOperand_ReturnsOperand()
        {
            // Arrange
            var evaluator = new PostfixEvaluation();
            var postfixExpression = new List<string> { "5" };

            // Act
            var result = evaluator.EvaluatePostix(postfixExpression);

            // Assert
            Assert.Equal("5", result);
        }

        [Fact]
        public void EvaluatePostfix_SimpleExpression_ReturnsCorrectResult()
        {
            // Arrange
            var evaluator = new PostfixEvaluation();
            var postfixExpression = new List<string> { "2", "3", "+" };

            // Act
            var result = evaluator.EvaluatePostix(postfixExpression);

            // Assert
            Assert.Equal("5", result);
        }

        [Fact]
        public void EvaluatePostfix_ComplexExpression_ReturnsCorrectResult()
        {
            // Arrange
            var evaluator = new PostfixEvaluation();
            var postfixExpression = new List<string> { "3", "4", "2", "*", "1", "5", "-", "2", "^", "3", "^", "/", "+" };

            // Act
            var result = evaluator.EvaluatePostix(postfixExpression);

            // Assert
            Assert.Equal("17", result); // Or whatever the correct calculated result is
        }

        [Fact]
        public void EvaluatePostfix_InvalidOperator_ReturnsErrorValue()
        {
            // Arrange
            var evaluator = new PostfixEvaluation();
            var postfixExpression = new List<string> { "5", "2", "$" }; 

            // Act
            var result = evaluator.EvaluatePostix(postfixExpression);

            // Assert
            Assert.Equal("-987656789", result);
        }
}