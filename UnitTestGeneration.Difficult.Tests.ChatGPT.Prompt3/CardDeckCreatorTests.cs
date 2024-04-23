using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class CardDeckCreatorTests
{
    [Fact]
    public void ConvertValue_ShouldReturnA_For1()
    {
        // Arrange & Act
        var result = CardDeckCreator.ConvertValue(1);

        // Assert
        Assert.Equal("A", result);
    }

    [Fact]
    public void ConvertValue_ShouldReturnJ_For11()
    {
        // Arrange & Act
        var result = CardDeckCreator.ConvertValue(11);

        // Assert
        Assert.Equal("J", result);
    }

    [Fact]
    public void ConvertValue_ShouldReturnQ_For12()
    {
        // Arrange & Act
        var result = CardDeckCreator.ConvertValue(12);

        // Assert
        Assert.Equal("Q", result);
    }

    [Fact]
    public void ConvertValue_ShouldReturnK_For13()
    {
        // Arrange & Act
        var result = CardDeckCreator.ConvertValue(13);

        // Assert
        Assert.Equal("K", result);
    }

    [Theory]
    [InlineData(1, 'C')]
    [InlineData(2, 'D')]
    [InlineData(3, 'H')]
    [InlineData(4, 'S')]
    public void ConvertSuit_ShouldReturnCorrectCharacter(int num, char expected)
    {
        // Arrange & Act
        var result = CardDeckCreator.ConvertSuit(num);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void SetCardDeck_ShouldCreateValidCardDeck(bool isHand)
    {
        // Arrange & Act
        var deck = CardDeckCreator.SetCardDeck(isHand);

        // Assert
        Assert.NotNull(deck);
        Assert.Equal(isHand ? 5 : 52, deck.Length);

        // Check for duplicates
        for (int i = 0; i < deck.Length - 1; i++)
        {
            for (int j = i + 1; j < deck.Length; j++)
            {
                Assert.NotEqual(deck[i].CardValue, deck[j].CardValue);
                Assert.NotEqual(deck[i].CardSuit, deck[j].CardSuit);
            }
        }
    }
}