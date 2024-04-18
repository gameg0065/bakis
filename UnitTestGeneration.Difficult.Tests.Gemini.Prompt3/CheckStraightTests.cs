using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt3;

public class CheckStraightTests
{
    [Fact]
    public void CheckForStraight_BasicStraight_ReturnsTrue()
    {
        CheckStraight.Card[] cardHand = {
            new ("5", "H"), 
            new("6", "D"),  
            new("7", "S"), 
            new("8", "C"), 
            new("9", "H") 
        };

        var result = CheckStraight.CheckForStraight(cardHand);

        Assert.True(result);
    }

    [Fact]
    public void CheckForStraight_EmptyHand_ReturnsFalse()
    {
        CheckStraight.Card[] cardHand = {}; // Empty array

        var result = CheckStraight.CheckForStraight(cardHand);

        Assert.False(result);
    }

    [Fact]
    public void CheckForStraight_AceLow_ReturnsTrue()
    {
        CheckStraight.Card[] cardHand = {
            new("A", "H"), 
            new("2", "D"),  
            new("3", "S"), 
            new("4", "C"), 
            new("5", "H") 
        };

        var result = CheckStraight.CheckForStraight(cardHand);

        Assert.True(result);
    }
}