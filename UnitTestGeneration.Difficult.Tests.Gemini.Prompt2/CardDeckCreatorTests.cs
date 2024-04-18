using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt2;

public class CardDeckCreatorTests
{
    // Test ConvertValue method
    [Theory]
    [InlineData(1, "A")]
    [InlineData(11, "J")]
    [InlineData(12, "Q")]
    [InlineData(13, "K")]
    [InlineData(5, "5")] // Example of an 'in-between' value
    [InlineData(-1, "-1")] // Edge case: Negative number
    [InlineData(14, "14")] // Edge case: Number greater than 13
    public void ConvertValue_ReturnsCorrectString(int input, string expected)
    {
        string result = CardDeckCreator.ConvertValue(input);
        Assert.Equal(expected, result);
    }

    // Test ConvertSuit method (similar structure to ConvertValue tests)
    // ...

    // Test SetCardDeck method
    [Fact]
    public void SetCardDeck_CreatesCorrectNumberOfCards()
    {
        CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck();
        Assert.Equal(52, cardDeck.Length); 

        CardDeckCreator.Card[] hand = CardDeckCreator.SetCardDeck(true);
        Assert.Equal(5, hand.Length); 
    }

    [Fact]
    public void SetCardDeck_CreatesUniqueCards()
    {
        CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck();

        // Ensure all elements are unique
        Assert.Equal(cardDeck.Length, cardDeck.Distinct().Count()); 
    }

    [Fact]
    public void SetCardDeck_CardsHaveValidValuesAndSuits()
    {
        CardDeckCreator.Card[] cardDeck = CardDeckCreator.SetCardDeck();

        foreach (var card in cardDeck)
        {
            // Values: "A", "2", "3" ... "10", "J", "Q", "K"
            Assert.Contains(card.CardValue, new[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" });

            // Suits: "C", "D", "H", "S"
            Assert.Contains(card.CardSuit, new[] { "C", "D", "H", "S" });
        }
    }
}