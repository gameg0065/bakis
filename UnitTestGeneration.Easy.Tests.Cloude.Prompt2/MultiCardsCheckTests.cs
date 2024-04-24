using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class MultiCardsCheckTests
{
    [Fact]
    public void CheckForMultiCards_NullArray_ReturnsZero()
    {
        // Arrange
        string[] valueCounters = null;
        int valueCount = 2;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_EmptyArray_ReturnsZero()
    {
        // Arrange
        string[] valueCounters = Array.Empty<string>();
        int valueCount = 2;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_NoMatchingValueCount_ReturnsZero()
    {
        // Arrange
        string[] valueCounters = { "K|1", "Q|3", "J|4" };
        int valueCount = 2;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CheckForMultiCards_SomeMatchingValueCount_ReturnsCorrectCount()
    {
        // Arrange
        string[] valueCounters = { "K|2", "Q|3", "J|2" };
        int valueCount = 2;

        // Act
        int result = MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void CheckForMultiCards_InvalidValueCounterFormat_ThrowsFormatException()
    {
        // Arrange
        string[] valueCounters = { "K|2", "Q|3", "InvalidFormat" };
        int valueCount = 2;

        // Act & Assert
        Assert.Throws<FormatException>(() => MultiCardsCheck.CheckForMultiCards(valueCounters, valueCount));
    }
}