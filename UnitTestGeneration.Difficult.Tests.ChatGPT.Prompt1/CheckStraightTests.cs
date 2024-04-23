using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1;

public class CheckStraightTests
{
[Fact]
    public void CheckForStraight_ShouldReturnTrue_WhenStraightExists()
    {
        // Arrange
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("2", "C"),
            new CheckStraight.Card("3", "D"),
            new CheckStraight.Card("4", "H"),
            new CheckStraight.Card("5", "S"),
            new CheckStraight.Card("6", "C")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cardHand);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckForStraight_ShouldReturnFalse_WhenStraightDoesNotExist()
    {
        // Arrange
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("2", "C"),
            new CheckStraight.Card("3", "D"),
            new CheckStraight.Card("4", "H"),
            new CheckStraight.Card("5", "S"),
            new CheckStraight.Card("8", "C")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cardHand);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckForStraight_ShouldReturnTrue_WhenStraightWithAceExists()
    {
        // Arrange
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "C"),
            new CheckStraight.Card("2", "D"),
            new CheckStraight.Card("3", "H"),
            new CheckStraight.Card("4", "S"),
            new CheckStraight.Card("5", "C")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cardHand);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckForStraight_ShouldReturnTrue_WhenStraightWithAceAsHighestExists()
    {
        // Arrange
        var cardHand = new CheckStraight.Card[]
        {
            new CheckStraight.Card("A", "C"),
            new CheckStraight.Card("10", "D"),
            new CheckStraight.Card("J", "H"),
            new CheckStraight.Card("Q", "S"),
            new CheckStraight.Card("K", "C")
        };

        // Act
        bool result = CheckStraight.CheckForStraight(cardHand);

        // Assert
        Assert.True(result);
    }
}