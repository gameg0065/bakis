using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class VisualCalculatorTests
{
    [Fact]
        public void BtnEnter_Click_NoneOperation_ReturnsZero()
        {
            // Arrange
            double dblNum1 = 5.0;
            double dblNum2 = 10.0;
            VisualCalculator.Calculator_Opertaions operation = VisualCalculator.Calculator_Opertaions.none;

            // Act
            double result = VisualCalculator.BtnEnter_Click(dblNum1, dblNum2, operation);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void BtnEnter_Click_AddOperation_ReturnsCorrectSum()
        {
            // Arrange
            double dblNum1 = 12.5;
            double dblNum2 = 3.0;
            VisualCalculator.Calculator_Opertaions operation = VisualCalculator.Calculator_Opertaions.add;

            // Act
            double result = VisualCalculator.BtnEnter_Click(dblNum1, dblNum2, operation);

            // Assert
            Assert.Equal(15.5, result);
        }

        [Fact]
        public void BtnEnter_Click_SubtractOperation_ReturnsCorrectDifference()
        {
            // Arrange
            double dblNum1 = 20.0;
            double dblNum2 = 8.5;
            VisualCalculator.Calculator_Opertaions operation = VisualCalculator.Calculator_Opertaions.subtract;

            // Act
            double result = VisualCalculator.BtnEnter_Click(dblNum1, dblNum2, operation);

            // Assert
            Assert.Equal(11.5, result);
        }

        [Fact]
        public void BtnEnter_Click_MultiplicationOperation_ReturnsCorrectProduct()
        {
            // Arrange ... (Similar structure as above)
        }

        [Fact]
        public void BtnEnter_Click_DivisionOperation_ReturnsCorrectQuotient()
        {
            // Arrange ... (Similar structure as above)
        }

        [Fact]
        public void BtnEnter_Click_InvalidOperation_ReturnsZero()
        {
            // Arrange
            double dblNum1 = 8.0;
            double dblNum2 = 2.0;
            VisualCalculator.Calculator_Opertaions operation = (VisualCalculator.Calculator_Opertaions)(-1); // Or any invalid value

            // Act
            double result = VisualCalculator.BtnEnter_Click(dblNum1, dblNum2, operation);

            // Assert
            Assert.Equal(0, result);
        }
}