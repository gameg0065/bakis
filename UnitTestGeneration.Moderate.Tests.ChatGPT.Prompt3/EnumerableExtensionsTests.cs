using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class EnumerableExtensionsTests
{
    [Fact]
    public void SequenceEqualOrderIgnore_BothNull_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = null;
        IEnumerable<int> second = null;

        // Act
        var result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_OneNull_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = new List<int> { 1, 2, 3 };
        IEnumerable<int> second = null;

        // Act
        var result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_DifferentLength_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = new List<int> { 1, 2, 3 };
        IEnumerable<int> second = new List<int> { 1, 2, 3, 4 };

        // Act
        var result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_EqualLists_ReturnsTrue()
    {
        // Arrange
        IEnumerable<int> first = new List<int> { 1, 2, 3 };
        IEnumerable<int> second = new List<int> { 1, 2, 3 };

        // Act
        var result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_UnorderedEqualLists_ReturnsTrue()
    {
        // Arrange
        IEnumerable<int> first = new List<int> { 1, 2, 3 };
        IEnumerable<int> second = new List<int> { 3, 2, 1 };

        // Act
        var result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_DifferentElementCounts_ReturnsFalse()
    {
        // Arrange
        IEnumerable<int> first = new List<int> { 1, 2, 2, 3 };
        IEnumerable<int> second = new List<int> { 1, 2, 3 };

        // Act
        var result = first.SequenceEqualOrderIgnore(second);

        // Assert
        Assert.False(result);
    }

}