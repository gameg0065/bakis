using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

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
    public void SequenceEqualOrderIgnore_EqualSequences_ReturnsTrue()
    {
        // Arrange
        IEnumerable<int> first = new[] { 1, 2, 3 };
        IEnumerable<int> second = new[] { 3, 1, 2 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_NonEqualSequences_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = new[] { 1, 2, 3 };
        IEnumerable<int> second = new[] { 3, 1, 2, 4 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_WithCustomComparer_ReturnsTrue()
    {
        // Arrange
        IEnumerable<string> first = new[] { "hello", "world" };
        IEnumerable<string> second = new[] { "WORLD", "HELLO" };
        var comparer = StringComparer.OrdinalIgnoreCase;

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second, comparer);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_WithDefaultComparer_ReturnsTrue()
    {
        // Arrange
        IEnumerable<int> first = new[] { 1, 2, 3 };
        IEnumerable<int> second = new[] { 3, 1, 2 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.True(result);
    }
}