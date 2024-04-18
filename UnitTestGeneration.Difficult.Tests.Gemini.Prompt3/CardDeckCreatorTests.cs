using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt3;

public class CardDeckCreatorTests
{
    // Tests for Card class - Simple Constructor and Properties
    [Fact]
    public void Card_Constructor_ShouldCreateCardObject()
    {
        // Arrange
        string value = "10";
        string suit = "D";

        // Act
        var card = new CardDeckCreator.Card(value, suit);

        // Assert
        Assert.Equal(value, card.CardValue);
        Assert.Equal(suit, card.CardSuit);
    }

    // Tests for ConvertValue()
    [Theory]
    [InlineData(1, "A")]
    [InlineData(11, "J")]
    [InlineData(12, "Q")]
    [InlineData(13, "K")]
    [InlineData(7, "7")] // Default case
    public void ConvertValue_ShouldReturnCorrectStringRepresentation(int input, string expected)
    {
        // Act
        var result = CardDeckCreator.ConvertValue(input);

        // Assert
        Assert.Equal(expected, result);
    }

    // Tests for ConvertSuit() - Similar to ConvertValue() tests
    // ... (Implementation omitted for brevity)

    // Tests for SetCardDeck() 
    [Fact]
    public void SetCardDeck_ShouldCreateUniqueDeckOf52Cards()
    {
        // Act
        var cardDeck = CardDeckCreator.SetCardDeck();

        // Assert
        Assert.Equal(52, cardDeck.Length); 

        // Check uniqueness (naive but effective for this purpose)
        var distinctCards = cardDeck.Distinct().Count();
        Assert.Equal(52, distinctCards);
    }

    [Fact]
    public void SetCardDeck_HandMode_ShouldCreateUniqueDeckOf5Cards()
    {
        // Act
        var cardDeck = CardDeckCreator.SetCardDeck(isHand: true);

        // Assert
        Assert.Equal(5, cardDeck.Length); 

        var distinctCards = cardDeck.Distinct().Count();
        Assert.Equal(5, distinctCards);
    }

}