using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class MultiCardsCheckTests
{
    [Theory]
    [InlineData(new string[] { "card1|2", "card2|2", "card3|3" }, 2, 2)] // Matching Values
    [InlineData(new string[] { "card1|1", "card2|3", "card3|3" }, 3, 2)] // Different Values
    [InlineData(new string[] { }, 1, 0)] // Empty Array
    public void CheckForMultiCards_CountsCorrectly(string[] valueCounters, int valueCount, int expected)
    {
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InvalidInput_ThrowsException()
    {
        string[] valueCounters = new string[] { "card1|2", "card2", "card3|3" }; 
        int valueCount = 2; 

        Assert.Throws<FormatException>(() => MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount));
    }
}