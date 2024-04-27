using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class CheckStraightTests
{
[Fact]
    public void ConvertValue_ReturnsCorrectValue()
    {
        // Arrange
        int[] inputs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        string[] expectedOutputs = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        // Act & Assert
        for (int i = 0; i < inputs.Length; i++)
        {
            string actualOutput = CheckStraight.ConvertValue(inputs[i]);
            Assert.Equal(expectedOutputs[i], actualOutput);
        }
    }

    [Fact]
    public void SearchCardValue_ReturnsTrue_WhenValueIsPresent()
    {
        // Arrange
        CheckStraight.Card[] cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "Hearts"),
            new CheckStraight.Card("2", "Clubs"),
            new CheckStraight.Card("3", "Diamonds"),
            new CheckStraight.Card("4", "Spades"),
            new CheckStraight.Card("5", "Hearts")
        };

        // Act & Assert
        Assert.True(CheckStraight.SearchCardValue("A", cards));
        Assert.True(CheckStraight.SearchCardValue("2", cards));
        Assert.True(CheckStraight.SearchCardValue("3", cards));
        Assert.True(CheckStraight.SearchCardValue("4", cards));
        Assert.True(CheckStraight.SearchCardValue("5", cards));
    }

    [Fact]
    public void SearchCardValue_ReturnsFalse_WhenValueIsNotPresent()
    {
        // Arrange
        CheckStraight.Card[] cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "Hearts"),
            new CheckStraight.Card("2", "Clubs"),
            new CheckStraight.Card("3", "Diamonds"),
            new CheckStraight.Card("4", "Spades"),
            new CheckStraight.Card("5", "Hearts")
        };

        // Act & Assert
        Assert.False(CheckStraight.SearchCardValue("6", cards));
        Assert.False(CheckStraight.SearchCardValue("7", cards));
        Assert.False(CheckStraight.SearchCardValue("8", cards));
        Assert.False(CheckStraight.SearchCardValue("9", cards));
        Assert.False(CheckStraight.SearchCardValue("10", cards));
    }

    [Fact]
    public void CheckForStraight_ReturnsTrue_WhenHandContainsAStraight()
    {
        // Arrange
        CheckStraight.Card[] cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "Hearts"),
            new CheckStraight.Card("2", "Clubs"),
            new CheckStraight.Card("3", "Diamonds"),
            new CheckStraight.Card("4", "Spades"),
            new CheckStraight.Card("5", "Hearts")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cards);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckForStraight_ReturnsTrue_WhenHandContainsAnotherStraight()
    {
        // Arrange
        CheckStraight.Card[] cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("6", "Hearts"),
            new CheckStraight.Card("7", "Clubs"),
            new CheckStraight.Card("8", "Diamonds"),
            new CheckStraight.Card("9", "Spades"),
            new CheckStraight.Card("10", "Hearts")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cards);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckForStraight_ReturnsFalse_WhenHandDoesNotContainAStraight()
    {
        // Arrange
        CheckStraight.Card[] cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "Hearts"),
            new CheckStraight.Card("2", "Clubs"),
            new CheckStraight.Card("3", "Diamonds"),
            new CheckStraight.Card("4", "Spades"),
            new CheckStraight.Card("7", "Hearts")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cards);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckForStraight_ReturnsFalse_WhenHandContainsAceButNoConsecutiveCards()
    {
        // Arrange
        CheckStraight.Card[] cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "Hearts"),
            new CheckStraight.Card("3", "Clubs"),
            new CheckStraight.Card("5", "Diamonds"),
            new CheckStraight.Card("7", "Spades"),
            new CheckStraight.Card("9", "Hearts")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cards);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckForStraight_ReturnsTrue_WhenHandContainsAceAndKingConsecutiveCards()
    {
        // Arrange
        CheckStraight.Card[] cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "Hearts"),
            new CheckStraight.Card("10", "Clubs"),
            new CheckStraight.Card("J", "Diamonds"),
            new CheckStraight.Card("Q", "Spades"),
            new CheckStraight.Card("K", "Hearts")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cards);

        // Assert
        Assert.True(result);
    }
}