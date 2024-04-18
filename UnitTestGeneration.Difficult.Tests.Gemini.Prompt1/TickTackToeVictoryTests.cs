using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class TickTackToeVictoryTests
{
    // Tests for victory conditions
    [Fact]
    public void CheckVictory_HorizontalWin()
    {
        var gridState = new string[] { "O", "O", "O", "4", "5", "6", "7", "8", "9" };
        var game = new TickTackToeVictory();

        Assert.True(game.CheckVictory(gridState));
    }

    [Fact]
    public void CheckVictory_VerticalWin()
    {
        var gridState = new string[] { "X", "2", "3", "X", "5", "6", "X", "8", "9" };
        var game = new TickTackToeVictory();

        Assert.True(game.CheckVictory(gridState));
    }

    // ... More tests for diagonal win and other winning combinations

    // Tests for no victory
    [Fact]
    public void CheckVictory_NoWin()
    {
        var gridState = new string[] { "X", "2", "O", "4", "X", "6", "O", "8", "9" };
        var game = new TickTackToeVictory();

        Assert.False(game.CheckVictory(gridState));
    }

    // Tests for edge cases (optional)
    [Fact]
    public void CheckVictory_EmptyGrid() 
    {
        var gridState = new string[9];
        var game = new TickTackToeVictory();

        Assert.False(game.CheckVictory(gridState)); 
        // Or you could decide to throw an exception for invalid input
    }
}