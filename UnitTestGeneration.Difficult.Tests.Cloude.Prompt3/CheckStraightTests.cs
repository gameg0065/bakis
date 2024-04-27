using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class CheckStraightTests
{
    [Fact]
    public void ConvertValue_ValidInput_ReturnsCorrectValue()
    {
        // Arrange
        var testCases = new[]
        {
            new { Input = 1, Expected = "A" },
            new { Input = 2, Expected = "2" },
            new { Input = 10, Expected = "10" },
            new { Input = 11, Expected = "J" },
            new { Input = 12, Expected = "Q" },
            new { Input = 13, Expected = "K" }
        };

        // Act & Assert
        foreach (var testCase in testCases)
        {
            var result = CheckStraight.ConvertValue(testCase.Input);
            Assert.Equal(testCase.Expected, result);
        }
    }

    [Fact]
    public void CheckForStraight_StraightHand_ReturnsTrue()
    {
        // Arrange
        var straightHands = new[]
        {
            new[] { new CheckStraight.Card("A", "H"), new CheckStraight.Card("2", "D"), new CheckStraight.Card("3", "C"), new CheckStraight.Card("4", "S"), new CheckStraight.Card("5", "H") },
            new[] { new CheckStraight.Card("10", "H"), new CheckStraight.Card("J", "D"), new CheckStraight.Card("Q", "C"), new CheckStraight.Card("K", "S"), new CheckStraight.Card("A", "H") },
            new[] { new CheckStraight.Card("3", "H"), new CheckStraight.Card("4", "D"), new CheckStraight.Card("5", "C"), new CheckStraight.Card("6", "S"), new CheckStraight.Card("7", "H") }
        };

        // Act & Assert
        foreach (var hand in straightHands)
        {
            var result = CheckStraight.CheckForStraight(hand);
            Assert.True(result);
        }
    }

    [Fact]
    public void CheckForStraight_NonStraightHand_ReturnsFalse()
    {
        // Arrange
        var nonStraightHands = new[]
        {
            new[] { new CheckStraight.Card("A", "H"), new CheckStraight.Card("2", "D"), new CheckStraight.Card("3", "C"), new CheckStraight.Card("4", "S"), new CheckStraight.Card("6", "H") },
            new[] { new CheckStraight.Card("10", "H"), new CheckStraight.Card("J", "D"), new CheckStraight.Card("Q", "C"), new CheckStraight.Card("K", "S"), new CheckStraight.Card("2", "H") },
            new[] { new CheckStraight.Card("3", "H"), new CheckStraight.Card("4", "D"), new CheckStraight.Card("5", "C"), new CheckStraight.Card("7", "S"), new CheckStraight.Card("8", "H") }
        };

        // Act & Assert
        foreach (var hand in nonStraightHands)
        {
            var result = CheckStraight.CheckForStraight(hand);
            Assert.False(result);
        }
    }

    [Fact]
    public void SearchCardValue_CardValuePresent_ReturnsTrue()
    {
        // Arrange
        var hand = new[] { new CheckStraight.Card("A", "H"), new CheckStraight.Card("2", "D"), new CheckStraight.Card("3", "C"), new CheckStraight.Card("4", "S"), new CheckStraight.Card("5", "H") };

        // Act & Assert
        Assert.True(CheckStraight.SearchCardValue("A", hand));
        Assert.True(CheckStraight.SearchCardValue("3", hand));
        Assert.True(CheckStraight.SearchCardValue("5", hand));
    }

    [Fact]
    public void SearchCardValue_CardValueNotPresent_ReturnsFalse()
    {
        // Arrange
        var hand = new[] { new CheckStraight.Card("A", "H"), new CheckStraight.Card("2", "D"), new CheckStraight.Card("3", "C"), new CheckStraight.Card("4", "S"), new CheckStraight.Card("5", "H") };

        // Act & Assert
        Assert.False(CheckStraight.SearchCardValue("6", hand));
        Assert.False(CheckStraight.SearchCardValue("J", hand));
        Assert.False(CheckStraight.SearchCardValue("Q", hand));
    }
}