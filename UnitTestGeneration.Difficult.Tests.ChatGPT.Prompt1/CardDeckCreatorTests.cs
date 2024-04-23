using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1;

public class CardDeckCreatorTests
{
    [Fact]
    public void ConvertValue_ShouldReturnCorrectString()
    {
        // Arrange
        int num = 1;

        // Act
        string result = CardDeckCreator.ConvertValue(num);

        // Assert
        Assert.Equal("A", result);
    }

    [Fact]
    public void ConvertSuit_ShouldReturnCorrectChar()
    {
        // Arrange
        int num = 1;

        // Act
        char result = CardDeckCreator.ConvertSuit(num);

        // Assert
        Assert.Equal('C', result);
    }

    [Fact]
    public void SetCardDeck_ShouldReturnCorrectNumberOfCards()
    {
        // Arrange & Act
        CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck();

        // Assert
        Assert.Equal(52, cardDeck.Length);
    }

    [Fact]
    public void SetCardDeck_WithHandParameter_ShouldReturnCorrectNumberOfCards()
    {
        // Arrange & Act
        CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck(isHand: true);

        // Assert
        Assert.Equal(5, cardDeck.Length);
    }

    // [Fact]
    // public void SetCardDeck_ShouldNotContainDuplicates()
    // {
    //     // Arrange & Act
    //     CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck();
    //
    //     // Assert
    //     Assert.NoDuplicates(cardDeck, card => $"{card.CardValue}|{card.CardSuit}");
    // }
}