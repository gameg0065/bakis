using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2;

public class CheckStraightTests
{
[Fact]
    public void ConvertValue_ShouldConvertCorrectly_WhenGivenNumber()
    {
        // Arrange & Act
        string resultA = CheckStraight.ConvertValue(1);
        string resultJ = CheckStraight.ConvertValue(11);
        string resultQ = CheckStraight.ConvertValue(12);
        string resultK = CheckStraight.ConvertValue(13);
        string resultOther = CheckStraight.ConvertValue(5);

        // Assert
        Assert.Equal("A", resultA);
        Assert.Equal("J", resultJ);
        Assert.Equal("Q", resultQ);
        Assert.Equal("K", resultK);
        Assert.Equal("5", resultOther);
    }

    [Fact]
    public void SearchCardValue_ShouldReturnTrue_WhenValueExistsInHand()
    {
        // Arrange
        var hand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "Spades"),
            new CheckStraight.Card("2", "Hearts"),
            new CheckStraight.Card("3", "Diamonds")
        };

        // Act
        bool result = CheckStraight.SearchCardValue("2", hand);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SearchCardValue_ShouldReturnFalse_WhenValueDoesNotExistInHand()
    {
        // Arrange
        var hand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "Spades"),
            new CheckStraight.Card("2", "Hearts"),
            new CheckStraight.Card("3", "Diamonds")
        };

        // Act
        bool result = CheckStraight.SearchCardValue("4", hand);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckForStraight_ShouldReturnTrue_WhenHandContainsStraight()
    {
        // Arrange
        var hand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("10", "Spades"),
            new CheckStraight.Card("J", "Hearts"),
            new CheckStraight.Card("Q", "Diamonds"),
            new CheckStraight.Card("K", "Clubs"),
            new CheckStraight.Card("A", "Spades")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(hand);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckForStraight_ShouldReturnFalse_WhenHandDoesNotContainStraight()
    {
        // Arrange
        var hand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("10", "Spades"),
            new CheckStraight.Card("9", "Hearts"),
            new CheckStraight.Card("Q", "Diamonds"),
            new CheckStraight.Card("K", "Clubs"),
            new CheckStraight.Card("A", "Spades")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(hand);

        // Assert
        Assert.False(result);
    }
}