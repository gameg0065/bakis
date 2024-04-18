using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class FractionConvertersTests
{
     // Tests for SafeDivision
        [Fact]
        public void SafeDivision_ZeroNumerator_ThrowsDivideByZeroException()
        {
            // Arrange
            decimal numerator = 0;
            decimal denominator = 5;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(numerator, denominator));
        }

        [Fact]
        public void SafeDivision_ZeroDenominator_ThrowsDivideByZeroException()
        {
            // Arrange
            decimal numerator = 10;
            decimal denominator = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(numerator, denominator));
        }

        [Fact]
        public void SafeDivision_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            decimal numerator = 25;
            decimal denominator = 5;
            decimal expectedResult = 5;

            // Act
            decimal result = FractionConverters.SafeDivision(numerator, denominator);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // Tests for Fraction
        [Fact]
        public void Fraction_ValidFractionString_ReturnsCorrectDecimal()
        {
            // Arrange
            string fracTxt = "3/4";
            decimal expectedResult = 0.75m; // Use 'm' for decimal literals

            // Act
            var converter = new FractionConverters();
            decimal result = converter.Fraction(fracTxt);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Fraction_ZeroDenominator_ThrowsDivideByZeroException()
        {
            // Arrange
            string fracTxt = "5/0";

            // Act & Assert            
            var converter = new FractionConverters();
            Assert.Throws<DivideByZeroException>(() => converter.Fraction(fracTxt));
        }

        // Tests for InchesSplit 
        [Fact]
        public void InchesSplit_ValidInput_ReturnsCorrectDecimal()
        {
            // Arrange
            string inchesTxt = "5'6\"";
            decimal expectedResult = 66;

            // Act
            var converter = new FractionConverters();
            decimal result = converter.InchesSplit(inchesTxt);

            // Assert
            Assert.Equal(expectedResult, result);
        }
}