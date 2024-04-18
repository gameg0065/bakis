using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class MultiCardsCheckTests
{
    [Fact]
    public void CheckForMultiCards_ShouldReturnZero_WhenValueCountersIsEmpty()
    {
        // Arrange
        string[] valueCounters = { };
        int valueCount = 3;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_ShouldReturnCorrectCount_WhenValueCountersContainsMatchingElements()
    {
        // Arrange
        string[] valueCounters = { "1|3", "2|3", "3|2", "4|1", "5|3" };
        int valueCount = 3;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void CheckForMultiCards_ShouldReturnZero_WhenValueCountersContainsNoMatchingElements()
    {
        // Arrange
        string[] valueCounters = { "1|1", "2|2", "3|1", "4|2", "5|1" };
        int valueCount = 3;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_ShouldHandleValueCountersWithInvalidFormats()
    {
        // Arrange
        string[] valueCounters = { "1|3", "2|a", "3|2", "4|1", "5|3" };
        int valueCount = 3;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(2, result);
    }
}