using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class MultiCardsCheckTests
{
    [Fact]
    public void CheckForMultiCards_ShouldReturnZero_WhenArrayIsEmpty()
    {
        // Arrange
        string[] valueCounters = { };
        int valueCount = 2;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(new string[] { "A|1", "2|3", "3|2", "4|1", "5|3" }, 1, 2)] // Two cards with count 1
    [InlineData(new string[] { "A|1", "2|3", "3|2", "4|1", "5|3" }, 2, 0)] // No cards with count 2
    [InlineData(new string[] { "A|1", "2|3", "3|2", "4|1", "5|3" }, 3, 2)] // Two cards with count 3
    public void CheckForMultiCards_ShouldReturnCorrectCount(string[] valueCounters, int valueCount, int expected)
    {
        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CheckForMultiCards_ShouldThrowFormatException_WhenValueCounterIsInvalid()
    {
        // Arrange
        string[] valueCounters = { "A|1", "2|3", "invalid" };
        int valueCount = 1;

        // Act & Assert
        Assert.Throws<FormatException>(() => MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount));
    }
}