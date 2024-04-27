using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class CardDeckCreatorTests
{
[Fact]
    public void ConvertValue_ValidInputs_ReturnsExpectedValues()
    {
        // Arrange
        var validInputs = new[]
        {
            new { Input = 1, Expected = "A" },
            new { Input = 11, Expected = "J" },
            new { Input = 12, Expected = "Q" },
            new { Input = 13, Expected = "K" },
            new { Input = 5, Expected = "5" },
            new { Input = 10, Expected = "10" }
        };

        // Act & Assert
        foreach (var testCase in validInputs)
        {
            var result = CardDeckCreator.ConvertValue(testCase.Input);
            Assert.Equal(testCase.Expected, result);
        }
    }

    [Theory]
    [InlineData(0)]
    [InlineData(14)]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void ConvertValue_InvalidInputs_ReturnsInputAsString(int input)
    {
        // Act
        var result = CardDeckCreator.ConvertValue(input);

        // Assert
        Assert.Equal(input.ToString(), result);
    }

    [Fact]
    public void ConvertSuit_ValidInputs_ReturnsExpectedValues()
    {
        // Arrange
        var validInputs = new[]
        {
            new { Input = 1, Expected = 'C' },
            new { Input = 2, Expected = 'D' },
            new { Input = 3, Expected = 'H' },
            new { Input = 4, Expected = 'S' }
        };

        // Act & Assert
        foreach (var testCase in validInputs)
        {
            var result = CardDeckCreator.ConvertSuit(testCase.Input);
            Assert.Equal(testCase.Expected, result);
        }
    }

    [Theory]
    [InlineData(0)]
    [InlineData(5)]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void ConvertSuit_InvalidInputs_ReturnsX(int input)
    {
        // Act
        var result = CardDeckCreator.ConvertSuit(input);

        // Assert
        Assert.Equal('X', result);
    }

    [Fact]
    public void SetCardDeck_DefaultCase_Returns52UniqueCards()
    {
        // Act
        var cardDeck = CardDeckCreator.SetCardDeck();

        // Assert
        Assert.Equal(52, cardDeck.Length);
        Assert.Equal(52, cardDeck.Distinct().Count());
    }

    [Fact]
    public void SetCardDeck_IsHandTrue_Returns5UniqueCards()
    {
        // Act
        var cardDeck = CardDeckCreator.SetCardDeck(true);

        // Assert
        Assert.Equal(5, cardDeck.Length);
        Assert.Equal(5, cardDeck.Distinct().Count());
    }
}