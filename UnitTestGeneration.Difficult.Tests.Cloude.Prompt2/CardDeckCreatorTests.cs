using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class CardDeckCreatorTests
{
    [Fact]
    public void ConvertValue_ShouldReturnCorrectValue()
    {
        // Arrange
        int[] inputValues = { 1, 2, 10, 11, 12, 13, 14 };
        string[] expectedValues = { "A", "2", "10", "J", "Q", "K", "14" };

        // Act & Assert
        for (int i = 0; i < inputValues.Length; i++)
        {
            string actualValue = CardDeckCreator.ConvertValue(inputValues[i]);
            Assert.Equal(expectedValues[i], actualValue);
        }
    }

    [Fact]
    public void ConvertSuit_ShouldReturnCorrectSuit()
    {
        // Arrange
        int[] inputSuits = { 1, 2, 3, 4, 5 };
        char[] expectedSuits = { 'C', 'D', 'H', 'S', 'X' };

        // Act & Assert
        for (int i = 0; i < inputSuits.Length; i++)
        {
            char actualSuit = CardDeckCreator.ConvertSuit(inputSuits[i]);
            Assert.Equal(expectedSuits[i], actualSuit);
        }
    }

    [Fact]
    public void SetCardDeck_ShouldReturnDistinctCards()
    {
        // Arrange
        CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck();

        // Act
        string[] cards = new string[cardDeck.Length];
        for (int i = 0; i < cardDeck.Length; i++)
        {
            cards[i] = $"{cardDeck[i].CardValue}{cardDeck[i].CardSuit}";
        }

        // Assert
        Assert.Equal(cards.Distinct().Count(), cards.Length);
    }

    [Fact]
    public void SetCardDeck_ShouldReturn52CardsForFullDeck()
    {
        // Arrange & Act
        CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck();

        // Assert
        Assert.Equal(52, cardDeck.Length);
    }

    [Fact]
    public void SetCardDeck_ShouldReturn5CardsForHand()
    {
        // Arrange & Act
        CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck(true);

        // Assert
        Assert.Equal(5, cardDeck.Length);
    }
}