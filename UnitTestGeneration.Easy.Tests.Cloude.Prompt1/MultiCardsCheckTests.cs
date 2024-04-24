using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class MultiCardsCheckTests
{
    [Fact]
    public void CheckForMultiCards_NoMatchingValues_ReturnsZero()
    {
        // Arrange
        string[] valueCounters = { "a|1", "b|2", "c|3" };
        int valueCount = 4;
        int expected = 0;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CheckForMultiCards_SingleMatchingValue_ReturnsOne()
    {
        // Arrange
        string[] valueCounters = { "a|1", "b|2", "c|3" };
        int valueCount = 3;
        int expected = 1;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CheckForMultiCards_MultipleMatchingValues_ReturnsCorrectCount()
    {
        // Arrange
        string[] valueCounters = { "a|2", "b|2", "c|3", "d|2" };
        int valueCount = 2;
        int expected = 3;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CheckForMultiCards_EmptyArray_ReturnsZero()
    {
        // Arrange
        string[] valueCounters = Array.Empty<string>();
        int valueCount = 5;
        int expected = 0;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CheckForMultiCards_InvalidInputFormat_ReturnsZero()
    {
        // Arrange
        string[] valueCounters = { "a", "b|2", "c|3" };
        int valueCount = 2;
        int expected = 0;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(expected, result);
    }
}