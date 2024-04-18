using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class PrimeNumbersTests
{
    // Tests for IsNumberEven
        [Fact]
        public void IsNumberEven_Zero_ReturnsTrue()
        {
            // Arrange
            int numberToCheck = 0;

            // Act
            bool result = PrimeNumbers.IsNumberEven(numberToCheck);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNumberEven_EvenNumber_ReturnsTrue()
        {
            // Arrange
            int numberToCheck = 8;

            // Act
            bool result = PrimeNumbers.IsNumberEven(numberToCheck);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNumberEven_OddNumber_ReturnsFalse()
        {
            // Arrange
            int numberToCheck = 7;

            // Act
            bool result = PrimeNumbers.IsNumberEven(numberToCheck);

            // Assert
            Assert.False(result);
        }

        // Tests for IsNumberPrime (Focus on key branching points in code)
        [Fact]
        public void IsNumberPrime_SmallPrime_ReturnsTrue()
        {
            // Arrange
            int numberToCheck = 7;

            // Act
            bool result = PrimeNumbers.IsNumberPrime(numberToCheck);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNumberPrime_NonPrimeDivisibleByThree_ReturnsFalse()
        {
            // Arrange
            int numberToCheck = 9;

            // Act
            bool result = PrimeNumbers.IsNumberPrime(numberToCheck);

            // Assert
            Assert.False(result);
        }

        // Add more tests for IsNumberPrime covering edge cases around Math.Sqrt

        // Tests for PrimeTest
        [Fact]
        public void PrimeTest_Zero_ReturnsFalse()
        {
            // Arrange
            int numberToCheck = 0;

            // Act
            bool result = PrimeNumbers.PrimeTest(numberToCheck);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void PrimeTest_One_ReturnsFalse()
        {
            // Arrange
            int numberToCheck = 1;

            // Act
            bool result = PrimeNumbers.PrimeTest(numberToCheck);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void PrimeTest_Two_ReturnsTrue()
        {
            // Arrange
            int numberToCheck = 2;

            // Act
            bool result = PrimeNumbers.PrimeTest(numberToCheck);

            // Assert
            Assert.True(result);
        }
}