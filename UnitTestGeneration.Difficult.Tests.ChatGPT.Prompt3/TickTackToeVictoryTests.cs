using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class TickTackToeVictoryTests
{
    [Fact]
    public void CheckVictory_ShouldReturnTrueForHorizontalVictory()
    {
        // Arrange
        var grid = new string[]
        {
            "X", "X", "X",
            "O", "O", "",
            "", "", ""
        };
        var tickTackToeVictory = new TickTackToeVictory();

        // Act
        var result = tickTackToeVictory.CheckVictory(grid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckVictory_ShouldReturnTrueForVerticalVictory()
    {
        // Arrange
        var grid = new string[]
        {
            "X", "O", "",
            "X", "O", "",
            "X", "", ""
        };
        var tickTackToeVictory = new TickTackToeVictory();

        // Act
        var result = tickTackToeVictory.CheckVictory(grid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckVictory_ShouldReturnTrueForDiagonalVictory()
    {
        // Arrange
        var grid = new string[]
        {
            "X", "O", "",
            "", "X", "O",
            "", "", "X"
        };
        var tickTackToeVictory = new TickTackToeVictory();

        // Act
        var result = tickTackToeVictory.CheckVictory(grid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckVictory_ShouldReturnFalseForNoVictory()
    {
        // Arrange
        var grid = new string[]
        {
            "X", "O", "",
            "", "X", "O",
            "", "", ""
        };
        var tickTackToeVictory = new TickTackToeVictory();

        // Act
        var result = tickTackToeVictory.CheckVictory(grid);

        // Assert
        Assert.False(result);
    }
}