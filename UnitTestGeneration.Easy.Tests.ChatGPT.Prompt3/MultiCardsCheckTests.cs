using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class MultiCardsCheckTests
{
    [Fact]
    public void CheckForMultiCards_ShouldReturnCorrectCount_ForValidValueCount()
    {
        // Arrange
        string[] valueCounters = { "card1|3", "card2|4", "card3|2", "card4|3", "card5|4" };
        int valueCount = 3;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(2, result); // Expecting 2 cards with value count 3
    }

    [Fact]
    public void CheckForMultiCards_ShouldReturnZero_ForInvalidValueCount()
    {
        // Arrange
        string[] valueCounters = { "card1|3", "card2|4", "card3|2", "card4|3", "card5|4" };
        int valueCount = 5; // No cards with value count 5

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_ShouldReturnCorrectCount_ForEmptyValueCounters()
    {
        // Arrange
        string[] valueCounters = new string[0];
        int valueCount = 3; // No cards to check

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_ShouldHandleInvalidValuesInValueCounters()
    {
        // Arrange
        string[] valueCounters = { "card1|3", "invalid", "card2|4" }; // Invalid value in the middle
        int valueCount = 3;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(1, result); // Expecting 1 card with value count 3
    }

    [Fact]
    public void CheckForMultiCards_ShouldHandleEmptyValueCounters()
    {
        // Arrange
        string[] valueCounters = { "", "", "" }; // Empty value counters
        int valueCount = 0; // Check for cards with value count 0

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }
}