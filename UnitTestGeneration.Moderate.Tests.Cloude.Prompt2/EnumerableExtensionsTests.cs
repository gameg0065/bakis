using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class EnumerableExtensionsTests
{
[Fact]
    public void SequenceEqualOrderIgnore_NullFirstSequence_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = null;
        IEnumerable<int> second = new[] { 1, 2, 3 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_NullSecondSequence_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = new[] { 1, 2, 3 };
        IEnumerable<int> second = null;

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_BothSequencesEmpty_ReturnsTrue()
    {
        // Arrange
        IEnumerable<int> first = new int[0];
        IEnumerable<int> second = new int[0];

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_SequencesEqual_ReturnsTrue()
    {
        // Arrange
        IEnumerable<int> first = new[] { 1, 2, 3, 2, 1 };
        IEnumerable<int> second = new[] { 3, 1, 2, 1, 2 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_SequencesNotEqual_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = new[] { 1, 2, 3 };
        IEnumerable<int> second = new[] { 1, 2, 2, 3 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_WithCustomComparer_SequencesEqual_ReturnsTrue()
    {
        // Arrange
        IEnumerable<string> first = new[] { "abc", "DEF", "ghi" };
        IEnumerable<string> second = new[] { "GHI", "def", "ABC" };
        IEqualityComparer<string> comparer = StringComparer.OrdinalIgnoreCase;

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second, comparer);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_WithCustomComparer_SequencesNotEqual_ReturnsFalse()
    {
        // Arrange
        IEnumerable<string> first = new[] { "abc", "DEF", "ghi" };
        IEnumerable<string> second = new[] { "GHI", "def", "ABC", "def" };
        IEqualityComparer<string> comparer = StringComparer.OrdinalIgnoreCase;

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second, comparer);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_WithDefaultComparer_SequencesEqual_ReturnsTrue()
    {
        // Arrange
        IEnumerable<int> first = new[] { 1, 2, 3, 2, 1 };
        IEnumerable<int> second = new[] { 3, 1, 2, 1, 2 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_WithDefaultComparer_SequencesNotEqual_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = new[] { 1, 2, 3 };
        IEnumerable<int> second = new[] { 1, 2, 2, 3 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.False(result);
    }
}