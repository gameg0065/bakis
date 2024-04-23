using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class CheckStraightTests
{
[Fact]
    public void ConvertValue_ShouldReturnCorrectValue()
    {
        // Arrange & Act
        var valueA = CheckStraight.ConvertValue(1);
        var valueJ = CheckStraight.ConvertValue(11);
        var valueQ = CheckStraight.ConvertValue(12);
        var valueK = CheckStraight.ConvertValue(13);
        var value5 = CheckStraight.ConvertValue(5);

        // Assert
        Assert.Equal("A", valueA);
        Assert.Equal("J", valueJ);
        Assert.Equal("Q", valueQ);
        Assert.Equal("K", valueK);
        Assert.Equal("5", value5);
    }

    [Fact]
    public void SearchCardValue_ShouldReturnTrueWhenCardValueExists()
    {
        // Arrange
        var cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "S"),
            new CheckStraight.Card("2", "H"),
            new CheckStraight.Card("5", "D"),
        };

        // Act
        var result = CheckStraight.SearchCardValue("5", cards);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SearchCardValue_ShouldReturnFalseWhenCardValueDoesNotExist()
    {
        // Arrange
        var cards = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "S"),
            new CheckStraight.Card("2", "H"),
            new CheckStraight.Card("5", "D"),
        };

        // Act
        var result = CheckStraight.SearchCardValue("7", cards);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(new string[] { "2", "3", "4", "5", "6" }, true)]
    [InlineData(new string[] { "A", "2", "3", "4", "5" }, true)]
    [InlineData(new string[] { "10", "J", "Q", "K", "A" }, true)]
    [InlineData(new string[] { "2", "3", "4", "5", "7" }, false)]
    public void CheckForStraight_ShouldReturnExpectedResult(string[] cardValues, bool expectedResult)
    {
        // Arrange
        var cards = new CheckStraight.Card[5];
        for (int i = 0; i < cardValues.Length; i++)
        {
            cards[i] = new CheckStraight.Card(cardValues[i], "S");
        }

        // Act
        var result = CheckStraight.CheckForStraight(cards);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}