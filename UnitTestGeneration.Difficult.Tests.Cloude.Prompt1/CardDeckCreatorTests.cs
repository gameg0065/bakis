using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class CardDeckCreatorTests
{
[Fact]
    public void ConvertValue_ValidInput_ReturnsCorrectValue()
    {
        // Arrange
        var testCases = new Dictionary<int, string>
        {
            {1, "A"},
            {5, "5"},
            {11, "J"},
            {12, "Q"},
            {13, "K"}
        };

        // Act & Assert
        foreach (var testCase in testCases)
        {
            var result = CardDeckCreator.ConvertValue(testCase.Key);
            Assert.Equal(testCase.Value, result);
        }
    }

    [Fact]
    public void ConvertSuit_ValidInput_ReturnsCorrectSuit()
    {
        // Arrange
        var testCases = new Dictionary<int, char>
        {
            {1, 'C'},
            {2, 'D'},
            {3, 'H'},
            {4, 'S'}
        };

        // Act & Assert
        foreach (var testCase in testCases)
        {
            var result = CardDeckCreator.ConvertSuit(testCase.Key);
            Assert.Equal(testCase.Value, result);
        }
    }

    [Fact]
    public void ConvertSuit_InvalidInput_ReturnsDefaultValue()
    {
        // Arrange
        int invalidInput = 5;
        char expectedResult = 'X';

        // Act
        var result = CardDeckCreator.ConvertSuit(invalidInput);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void SetCardDeck_WithoutHand_ReturnsFullDeck()
    {
        // Arrange
        int expectedDeckSize = 52;

        // Act
        var cardDeck = CardDeckCreator.SetCardDeck();

        // Assert
        Assert.Equal(expectedDeckSize, cardDeck.Length);
        Assert.Equal(expectedDeckSize, new HashSet<string>(cardDeck.Select(c => $"{c.CardValue}{c.CardSuit}")).Count);
    }

    [Fact]
    public void SetCardDeck_WithHand_ReturnsHandOfFiveCards()
    {
        // Arrange
        int expectedHandSize = 5;

        // Act
        var cardDeck = CardDeckCreator.SetCardDeck(true);

        // Assert
        Assert.Equal(expectedHandSize, cardDeck.Length);
        Assert.Equal(expectedHandSize, new HashSet<string>(cardDeck.Select(c => $"{c.CardValue}{c.CardSuit}")).Count);
    }
}