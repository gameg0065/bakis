using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class CardDeckCreatorTests
{
    [Fact]
    public void Card_PropertiesSetCorrectly()
    {
        var card = new CardDeckCreator.Card("10", "H");
        Assert.Equal("10", card.CardValue);
        Assert.Equal("H", card.CardSuit);
    }
    
    [Theory]
    [InlineData(1, "A")]
    [InlineData(11, "J")]
    [InlineData(12, "Q")]
    [InlineData(13, "K")]
    [InlineData(5, "5")] 
    public void ConvertValue_ReturnsCorrectString(int input, string expected)
    {
        var result = CardDeckCreator.ConvertValue(input);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(1, 'C')]
    [InlineData(2, 'D')]
    [InlineData(3, 'H')]
    [InlineData(4, 'S')]
    [InlineData(5, 'X')] // For the default case
    public void ConvertSuit_ReturnsCorrectChar(int input, char expected)
    {
        var result = CardDeckCreator.ConvertSuit(input);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SetCardDeck_CreatesStandardDeck()
    {
        var deck = CardDeckCreator.SetCardDeck();
        Assert.Equal(52, deck.Length);
    }

    [Fact]
    public void SetCardDeck_CreatesHand()
    {
        var hand = CardDeckCreator.SetCardDeck(true); 
        Assert.Equal(5, hand.Length);
    }

    [Fact]
    public void SetCardDeck_NoDuplicates() 
    {
        var deck = CardDeckCreator.SetCardDeck();
        var distinctCards = deck.Distinct().Count();
        Assert.Equal(deck.Length, distinctCards);
    }

    [Fact]
    public void SetCardDeck_CardsHaveValidFormat()
    {
        var deck = CardDeckCreator.SetCardDeck();
        foreach (var card in deck)
        {
            Assert.Contains("|", card.CardValue + card.CardSuit); // Simple check 
        }
    }
}