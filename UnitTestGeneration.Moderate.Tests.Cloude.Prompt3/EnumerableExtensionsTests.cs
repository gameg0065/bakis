using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class EnumerableExtensionsTests
{
    [Theory]
    [InlineData(null, null)]
    [InlineData(null, new int[] { })]
    [InlineData(new int[] { }, null)]
    public void SequenceEqualOrderIgnore_NullInput_ReturnsFalse(IEnumerable<int> first, IEnumerable<int> second)
    {
        Assert.False(first.SequenceEqualOrderIgnore(second));
    }

    // [Theory]
    // [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
    // [InlineData(new int[] { 1, 2, 3, 1 }, new int[] { 1, 1, 3, 2 })]
    // [InlineData(new string[] { "a", "b", "c" }, new string[] { "c", "a", "b" })]
    // public void SequenceEqualOrderIgnore_EqualSequences_ReturnsTrue(IEnumerable<object> first, IEnumerable<object> second)
    // {
    //     Assert.True(first.SequenceEqualOrderIgnore(second));
    // }
    //
    // [Theory]
    // [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 })]
    // [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
    // [InlineData(new string[] { "a", "b", "c" }, new string[] { "a", "b" })]
    // public void SequenceEqualOrderIgnore_UnequalSequences_ReturnsFalse(IEnumerable<object> first, IEnumerable<object> second)
    // {
    //     Assert.False(first.SequenceEqualOrderIgnore(second));
    // }
    //
    // [Theory]
    // [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, EqualityComparer<int>.Default)]
    // [InlineData(new int[] { 1, 2, 3, 1 }, new int[] { 1, 1, 3, 2 }, null)]
    // [InlineData(new string[] { "a", "b", "c" }, new string[] { "c", "a", "b" }, StringComparer.OrdinalIgnoreCase)]
    // public void SequenceEqualOrderIgnore_WithComparer_ReturnsExpectedResult(IEnumerable<object> first, IEnumerable<object> second, IEqualityComparer<object> comparer)
    // {
    //     Assert.True(first.SequenceEqualOrderIgnore(second, comparer));
    // }

    [Fact]
    public void SequenceEqualOrderIgnore_DefaultComparer_CallsOverloadWithComparer()
    {
        var first = new int[] { 1, 2, 3 };
        var second = new int[] { 1, 2, 3 };

        Assert.True(first.SequenceEqualOrderIgnore(second));
    }
}