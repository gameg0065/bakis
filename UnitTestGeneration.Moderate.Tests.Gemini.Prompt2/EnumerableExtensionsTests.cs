using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class EnumerableExtensionsTests
{
    [Fact]
    public void SequenceEqualOrderIgnore_FirstSequenceNull_ReturnsFalse()
    {
        IEnumerable<int> first = null;
        IEnumerable<int> second = new int[] { 1, 2, 3 };

        var result = first.SequenceEqualOrderIgnore(second);

        Assert.False(result);
    }
    [Fact]
    public void SequenceEqualOrderIgnore_MatchingSequences_ReturnsTrue()
    {
        IEnumerable<string> first = new string[] { "hello", "world", "hello" };
        IEnumerable<string> second = new string[] { "world", "hello", "hello" };

        var result = first.SequenceEqualOrderIgnore(second);

        Assert.True(result);
    }
    [Fact]
    public void SequenceEqualOrderIgnore_NonMatchingSequences_ReturnsFalse()
    {
        IEnumerable<int> first = new int[] { 1, 2, 2, 4 };
        IEnumerable<int> second = new int[] { 1, 2, 4 };

        var result = first.SequenceEqualOrderIgnore(second);

        Assert.False(result);
    }
    
    [Fact]
    public void SequenceEqualOrderIgnore_CustomComparer_ReturnsTrue()
    {
        IEnumerable<string> first = new string[] { "HELLO", "world" };
        IEnumerable<string> second = new string[] { "World", "hello" };

        var result = first.SequenceEqualOrderIgnore(second, StringComparer.OrdinalIgnoreCase);

        Assert.True(result);
    }
}