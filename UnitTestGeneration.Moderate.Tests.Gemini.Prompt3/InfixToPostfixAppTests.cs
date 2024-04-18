using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class InfixToPostfixAppTests
{
    [Fact]
        public void InfixToPostfix_EmptyExpression_ReturnsEmptyList()
        {
            // Arrange
            var converter = new InfixToPostfixApp();
            string infixExpression = "";

            // Act
            List<string> result = converter.InfixToPostfix(infixExpression);

            // Assert
            Assert.Empty(result); 
        }

        [Fact]
        public void InfixToPostfix_SingleOperand_ReturnsOperand()
        {
            // Arrange
            var converter = new InfixToPostfixApp();
            string infixExpression = "5";

            // Act
            List<string> result = converter.InfixToPostfix(infixExpression);

            // Assert
            Assert.Equal(new List<string> { "5" }, result);
        }

        [Fact]
        public void InfixToPostfix_SimpleExpression_ReturnsCorrectPostfix()
        {
            // Arrange
            var converter = new InfixToPostfixApp();
            string infixExpression = "2 + 3";

            // Act
            List<string> result = converter.InfixToPostfix(infixExpression);

            // Assert
            Assert.Equal(new List<string> { "2", "3", "+" }, result);
        }

        [Fact]
        public void InfixToPostfix_ExpressionWithParentheses_ReturnsCorrectPostfix()
        {
            // Arrange
            var converter = new InfixToPostfixApp();
            string infixExpression = "(2 + 3) * 5";

            // Act
            List<string> result = converter.InfixToPostfix(infixExpression);

            // Assert
            Assert.Equal(new List<string> { "2", "3", "+", "5", "*" }, result);
        }

        [Fact]
        public void InfixToPostfix_ComplexExpression_ReturnsCorrectPostfix()
        {
            // Arrange
            var converter = new InfixToPostfixApp();
            string infixExpression = "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";

            // Act
            List<string> result = converter.InfixToPostfix(infixExpression);

            // Assert
            Assert.Equal(new List<string> { "3", "4", "2", "*", "1", "5", "-", "2", "^", "3", "^", "/", "+" }, result); 
        }

        [Fact]
        public void InfixToPostfix_InvalidToken_ThrowsException()
        {
            // Arrange
            var converter = new InfixToPostfixApp();
            string infixExpression = "5 + $"; // $ is an invalid token

            // Act & Assert
            Assert.Throws<FormatException>(() => converter.InfixToPostfix(infixExpression));
        }
}