using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class EnumerableExtensionsTests
{
    // Tests for SequenceEqualOrderIgnore with custom comparer
        [Fact]
        public void SequenceEqualOrderIgnore_NullInputs_ReturnsFalse()
        {
            // Arrange
            IEnumerable<string> first = null;
            IEnumerable<string> second = new string[] { "hello" };

            // Act
            bool result = first.SequenceEqualOrderIgnore(second, StringComparer.OrdinalIgnoreCase);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void SequenceEqualOrderIgnore_EqualSequences_ReturnsTrue()
        {
            // Arrange
            IEnumerable<int> first = new int[] { 1, 3, 2, 2 };
            IEnumerable<int> second = new int[] { 2, 1, 2, 3 };

            // Act
            bool result = first.SequenceEqualOrderIgnore(second);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void SequenceEqualOrderIgnore_DifferentCount_ReturnsFalse()
        {
            IEnumerable<string> first = new string[] { "hello", "world", "hello" };
            IEnumerable<string> second = new string[] { "Hello", "world" };

            bool result = first.SequenceEqualOrderIgnore(second, StringComparer.OrdinalIgnoreCase);

            Assert.False(result);
        }

        [Fact]
        public void SequenceEqualOrderIgnore_CustomComparer_ReturnsTrue()
        {
            IEnumerable<string> first = new string[] { "Hello", "world", "HELLO" };
            IEnumerable<string> second = new string[] { "hello", "WORLD" };

            bool result = first.SequenceEqualOrderIgnore(second, StringComparer.OrdinalIgnoreCase);

            Assert.True(result);
        }

        // Tests for SequenceEqualOrderIgnore with the default comparer
        [Fact]
        public void SequenceEqualOrderIgnore_DefaultComparer_CaseSensitive()
        {
            IEnumerable<string> first = new string[] { "Hello", "world", "HELLO" };
            IEnumerable<string> second = new string[] { "hello", "WORLD" };

            bool result = first.SequenceEqualOrderIgnore(second); 

            Assert.False(result);
        }
}