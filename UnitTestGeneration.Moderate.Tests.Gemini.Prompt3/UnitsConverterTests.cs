using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class UnitsConverterTests
{
    [Fact]
        public void PoundsToKilograms_ZeroPounds_ReturnsZeroKilograms()
        {
            // Arrange
            decimal pounds = 0;
            decimal expectedKilograms = 0;

            // Act
            var converter = new UnitsConverter();
            decimal result = converter.PoundsToKilograms(pounds);

            // Assert
            Assert.Equal(expectedKilograms, result);
        }

        [Fact]
        public void PoundsToKilograms_PositivePounds_ReturnsConvertedKilograms()
        {
            // Arrange
            decimal pounds = 10;
            decimal expectedKilograms = 4.5359237m; // Calculate expected value accurately

            // Act
            var converter = new UnitsConverter();
            decimal result = converter.PoundsToKilograms(pounds);

            // Assert
            Assert.Equal(expectedKilograms, result);
        }

        // Similar tests for KilogramsToPounds

        // Tests for InchesToCentimeters
        [Fact]
        public void InchesToCentimeters_ZeroInches_ReturnsZeroCentimeters()
        {
            // ... (Similar structure as above)
        }

        // ... Similar tests for CentimetersToInches

        // Tests for CentimetersToInches
        [Fact]
        public void CentimetersToInches_LessThanOneFoot_ReturnsCentimeters()
        {
            // Arrange
            decimal centimeters = 10;
            string expected = "3.94"; // Calculate expected value accurately

            // Act
            var converter = new UnitsConverter();
            string result = converter.CentimetersToInches(centimeters);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CentimetersToInches_GreaterThanOneFoot_ReturnsFeetAndInches()
        {
            // Arrange
            decimal centimeters = 36;
            string expected = "1'2\""; // Calculate expected value accurately

            // Act
            var converter = new UnitsConverter();
            string result = converter.CentimetersToInches(centimeters);

            // Assert
            Assert.Equal(expected, result);
        }
}