using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini;

public class MultiCardsCheckTests
{
    [Fact]
    public void TestMultipleOccurrences()
    {
        string[] valueCounters = { "card1|2", "card2|5", "card3|2" };
        int valueCount = 2;
        int expectedCount = 2;  // Two cards have a count of 2

        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void TestNoOccurrences()
    {
        string[] valueCounters = { "card1|1", "card2|3", "card3|5" };
        int valueCount = 2;
        int expectedCount = 0; 

        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void TestEmptyArray()
    {
        string[] valueCounters = new string[0];
        int valueCount = 10; // Doesn't matter with an empty array
        int expectedCount = 0; 

        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void TestInvalidInputFormat()
    {
        string[] valueCounters = { "card1|1", "card2", "card3|X" }; // Invalid formats
        int valueCount = 2; 

        // Might want to throw an exception for invalid input
        Assert.Throws<FormatException>(() => MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount));
    }
}