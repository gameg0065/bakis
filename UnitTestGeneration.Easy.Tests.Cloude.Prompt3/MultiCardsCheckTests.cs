using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class MultiCardsCheckTests
{
    [Theory]
    [InlineData(new string[] { "A|1", "B|2", "C|3" }, 1, 1)]
    [InlineData(new string[] { "X|4", "Y|4", "Z|5" }, 4, 2)]
    [InlineData(new string[] { "1|6", "2|6", "3|6", "4|6" }, 6, 4)]
    public void CheckForMultiCards_WithMatchingValues_ReturnsCorrectCount(string[] valueCounters, int valueCount, int expected)
    {
        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new string[] { "A|1", "B|2", "C|3" }, 4, 0)]
    [InlineData(new string[] { "X|4", "Y|5", "Z|6" }, 7, 0)]
    [InlineData(new string[] { }, 10, 0)]
    public void CheckForMultiCards_WithNoMatchingValues_ReturnsZero(string[] valueCounters, int valueCount, int expected)
    {
        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CheckForMultiCards_WithNullValueCounters_ThrowsArgumentNullException()
    {
        // Arrange
        string[] valueCounters = null;
        int valueCount = 1;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount));
    }

    [Fact]
    public void CheckForMultiCards_WithInvalidValueCounterFormat_ThrowsFormatException()
    {
        // Arrange
        string[] valueCounters = { "A|B", "C|D" };
        int valueCount = 1;

        // Act & Assert
        Assert.Throws<FormatException>(() => MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount));
    }

    [Fact]
    public void CheckForMultiCards_WithEmptyValueCounters_ReturnsZero()
    {
        // Arrange
        string[] valueCounters = Array.Empty<string>();
        int valueCount = 1;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }
}