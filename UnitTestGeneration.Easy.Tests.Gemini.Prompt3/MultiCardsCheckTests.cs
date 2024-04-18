using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class MultiCardsCheckTests
{
    [Fact]
    public void CheckForMultiCards_EmptyArray_ReturnsZero()
    {
        string[] valueCounters = new string[0];
        int valueCount = 2;

        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_NoMatches_ReturnsZero()
    {
        string[] valueCounters = { "card1|1", "card2|3", "card3|5" };
        int valueCount = 2;

        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_SingleMatch_ReturnsOne()
    {
        string[] valueCounters = { "card1|1", "card2|2", "card3|5" };
        int valueCount = 2;

        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);
        Assert.Equal(1, result);
    }

    [Fact]
    public void CheckForMultiCards_MultipleMatches_ReturnsCorrectCount()
    {
        string[] valueCounters = { "card1|3", "card2|2", "card3|3", "card4|3" };
        int valueCount = 3;

        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);
        Assert.Equal(3, result);
    }

    [Fact]
    public void CheckForMultiCards_InvalidInput_HandlesException()
    {
        string[] valueCounters = { "card1|x", "card2|2", "card3|5" }; // 'x' is not a number
        int valueCount = 2;

        Assert.Throws<FormatException>(() => MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount));
    }
}