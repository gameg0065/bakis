using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class EnumerableExtensionsTests
{
    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsTrue_WhenSequencesAreEqual()
    {
        // Arrange
        var first = new[] { 1, 2, 3, 4 };
        var second = new[] { 1, 2, 3, 4 };

        // Act
        bool result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsFalse_WhenSequencesHaveDifferentElements()
    {
        // Arrange
        var first = new[] { 1, 2, 3, 4 };
        var second = new[] { 1, 2, 3, 5 };

        // Act
        bool result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsTrue_WhenSequencesHaveSameElementsInDifferentOrder()
    {
        // Arrange
        var first = new[] { 1, 2, 3, 4 };
        var second = new[] { 4, 3, 2, 1 };

        // Act
        bool result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsTrue_WhenSequencesHaveSameElementsWithCustomComparer()
    {
        // Arrange
        var first = new[] { "apple", "banana", "orange" };
        var second = new[] { "APPLE", "BANANA", "ORANGE" };
        var comparer = StringComparer.OrdinalIgnoreCase;

        // Act
        bool result = first.SequenceEqualOrderIgnore(second, comparer);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsFalse_WhenSecondSequenceIsNull()
    {
        // Arrange
        var first = new[] { 1, 2, 3, 4 };
        IEnumerable<int> second = null;

        // Act
        bool result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsFalse_WhenFirstSequenceIsNull()
    {
        // Arrange
        IEnumerable<int> first = null;
        var second = new[] { 1, 2, 3, 4 };

        // Act
        bool result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.False(result);
    }
}