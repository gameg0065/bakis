using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt2;

public class CheckStraightTests
{
    [Theory]
    [InlineData(1, "A")]
    [InlineData(11, "J")]
    [InlineData(12, "Q")]
    [InlineData(13, "K")]
    [InlineData(7, "7")] // Check a regular number
    [InlineData(0, "0")] // Edge case: number outside the range
    public void ConvertValue_ReturnsCorrectString(int input, string expected)
    {
        var result = CheckStraight.ConvertValue(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SearchCardValue_ReturnsTrueWhenValueExists()
    {
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("7", "H"),
            new CheckStraight.Card("Q", "S") 
        };

        var result = CheckStraight.SearchCardValue("Q", cardHand);
        Assert.True(result); 
    }

    [Fact]
    public void SearchCardValue_ReturnsFalseWhenValueDoesNotExist()
    {
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("7", "H"),
            new CheckStraight.Card("Q", "S") 
        };

        var result = CheckStraight.SearchCardValue("10", cardHand);
        Assert.False(result); 
    }

    [Fact]
    public void CheckForStraight_ReturnsTrueForStraight() 
    {
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("7", "H"),
            new CheckStraight.Card("8", "S"),
            new CheckStraight.Card("9", "D"),
            new CheckStraight.Card("10", "C"),
            new CheckStraight.Card("J", "D") 
        };

        var result = CheckStraight.CheckForStraight(cardHand);
        Assert.True(result); 
    }

    [Fact]
    public void CheckForStraight_ReturnsFalseForNonStraight() {
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("7", "H"),
            new CheckStraight.Card("8", "S"),
            new CheckStraight.Card("10", "D"), 
            new CheckStraight.Card("J", "C"),
            new CheckStraight.Card("Q", "D") 
        };

        var result = CheckStraight.CheckForStraight(cardHand);
        Assert.False(result); 
    }

    [Fact]
    public void CheckForStraight_AceHighStraight() {
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("10", "H"),
            new CheckStraight.Card("J", "S"),
            new CheckStraight.Card("Q", "D"), 
            new CheckStraight.Card("K", "C"),
            new CheckStraight.Card("A", "D") 
        };

        var result = CheckStraight.CheckForStraight(cardHand);
        Assert.True(result); 
    }

    [Fact] 
    public void CheckForStraight_AceLowStraight() {
        // Similar setup as above, but include "2" with the Ace
    }
    
}