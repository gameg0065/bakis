using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class EnumerableExtensionsTests
{
    [Fact]
    public void NullInput_ReturnsFalse()
    {
        IEnumerable<int> first = null;
        IEnumerable<int> second = new List<int> { 1, 2, 3 };
        bool result = first.SequenceEqualOrderIgnore(second);
        Assert.False(result);
    }

    [Fact]
    public void EqualSequences_DefaultComparer_ReturnsTrue()
    {
        IEnumerable<string> first = new List<string> { "hello", "world" };
        IEnumerable<string> second = new List<string> { "hello", "world" };
        bool result = first.SequenceEqualOrderIgnore(second);
        Assert.True(result);
    }

    [Fact]
    public void EqualSequences_CustomComparer_ReturnsTrue()
    {
        List<string> first = new List<string> { "HELLO", "World" };
        List<string> second = new List<string> { "hello", "WORLD" };
        bool result = first.SequenceEqualOrderIgnore(second, StringComparer.OrdinalIgnoreCase);
        Assert.True(result);
    }
}