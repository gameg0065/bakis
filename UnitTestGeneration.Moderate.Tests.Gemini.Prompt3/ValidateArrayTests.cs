using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class ValidateArrayTests
{
    [Fact]
        public void ValidMountainArray_EmptyArray_ReturnsFalse()
        {
            // Arrange
            int[] arr = new int[] { };

            // Act
            var validator = new ValidateArray();
            bool result = validator.ValidMountainArray(arr);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_TooShort_ReturnsFalse()
        {
            // Arrange
            int[] arr = new int[] { 1, 2 };

            // Act
            var validator = new ValidateArray();
            bool result = validator.ValidMountainArray(arr);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_NotStrictlyIncreasing_ReturnsFalse()
        {
            // Arrange
            int[] arr = new int[] { 2, 2, 3, 1 };

            // Act
            var validator = new ValidateArray();
            bool result = validator.ValidMountainArray(arr);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_NotStrictlyDecreasing_ReturnsFalse()
        {
            // Arrange
            int[] arr = new int[] { 0, 2, 3, 3, 1 };

            // Act
            var validator = new ValidateArray();
            bool result = validator.ValidMountainArray(arr);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_StartsWithDecrease_ReturnsFalse()
        {
            // Arrange
            int[] arr = new int[] { 2, 1, 0 };

            // Act
            var validator = new ValidateArray();
            bool result = validator.ValidMountainArray(arr);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_EndsWithIncrease_ReturnsFalse()
        {
            // Arrange
            int[] arr = new int[] { 0, 1, 2, 1 };

            // Act
            var validator = new ValidateArray();
            bool result = validator.ValidMountainArray(arr);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_ValidInput_ReturnsTrue()
        {
            // Arrange
            int[] arr = new int[] { 0, 2, 3, 2, 1 };

            // Act
            var validator = new ValidateArray();
            bool result = validator.ValidMountainArray(arr);

            // Assert
            Assert.True(result);
        }
}