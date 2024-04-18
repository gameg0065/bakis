using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class EnumerableExtensionsTests
{
    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsFalse_ForNullSequences()
    {
        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore<object>(null, null);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsFalse_ForOneNullSequence()
    {
        // Arrange
        IEnumerable<int> first = new List<int> { 1, 2, 3 };

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, null);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SequenceEqualOrderIgnore_ReturnsTrue_ForEmptySequences()
    {
        // Arrange
        IEnumerable<int> first = new List<int>();
        IEnumerable<int> second = new List<int>();

        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 })]
    public void SequenceEqualOrderIgnore_ReturnsFalse_ForDifferentLengthSequences(IEnumerable<int> first, IEnumerable<int> second)
    {
        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 2, 3, 1 })]
    public void SequenceEqualOrderIgnore_ReturnsTrue_ForSameElementsInDifferentOrder(IEnumerable<int> first, IEnumerable<int> second)
    {
        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    public void SequenceEqualOrderIgnore_ReturnsTrue_ForSameElementsInSameOrder(IEnumerable<int> first, IEnumerable<int> second)
    {
        // Act
        bool result = EnumerableExtensions.SequenceEqualOrderIgnore(first, second);

        // Assert
        Assert.True(result);
    }
}