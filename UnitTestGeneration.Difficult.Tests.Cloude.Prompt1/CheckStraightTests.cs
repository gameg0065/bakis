using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class CheckStraightTests
{
    [Fact]
    public void CheckForStraight_StraightHand_ReturnsTrue()
    {
        // Arrange
        var cards = new[]
        {
            new CheckStraight.Card("2", "H"),
            new CheckStraight.Card("3", "D"),
            new CheckStraight.Card("4", "C"),
            new CheckStraight.Card("5", "S"),
            new CheckStraight.Card("6", "H")
        };

        // Act
        var result = CheckStraight.CheckForStraight(cards);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckForStraight_NonStraightHand_ReturnsFalse()
    {
        // Arrange
        var cards = new[]
        {
            new CheckStraight.Card("2", "H"),
            new CheckStraight.Card("3", "D"),
            new CheckStraight.Card("5", "C"),
            new CheckStraight.Card("7", "S"),
            new CheckStraight.Card("9", "H")
        };

        // Act
        var result = CheckStraight.CheckForStraight(cards);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(1, "A")]
    [InlineData(11, "J")]
    [InlineData(12, "Q")]
    [InlineData(13, "K")]
    [InlineData(5, "5")]
    public void ConvertValue_ValidInput_ReturnsExpectedValue(int input, string expected)
    {
        // Act
        var result = CheckStraight.ConvertValue(input);

        // Assert
        Assert.Equal(expected, result);
    }
}