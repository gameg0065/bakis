using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt3;

public class TickTackToeVictoryTests
{
    [Theory]
    [InlineData(new string[] { "X", "X", "X", "O", "O", " ", " ", " ", " " }, true)] // Row win
    [InlineData(new string[] { "O", " ", " ", "O", " ", " ", "O", " ", " " }, true)] // Column win
    [InlineData(new string[] { "X", " ", " ", " ", "X", " ", " ", " ", "X" }, true)] // Diagonal win
    [InlineData(new string[] { "X", "O", "O", "X", "X", " ", "O", " ", "X" }, false)] // No win
    [InlineData(new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " " }, false)] // Empty board
    public void CheckVictory_VariousScenarios_ReturnsCorrectly(string[] grid, bool expected)
    {
        var checker = new TickTackToeVictory();
        var result = checker.CheckVictory(grid);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CheckVictory_MutationTest_DetectsChange()
    {
        var checker = new TickTackToeVictory();

        // Introduce a small change in the original code (example):
        // Original: bool diagDown = grid[0] == grid[4] && grid[4] == grid[8];
        // Change:   bool diagDown = grid[0] == grid[4] || grid[4] == grid[8]; 

        var winningGrid = new string[] { "X", " ", " ", " ", "X", " ", " ", " ", "X" };
        var result = checker.CheckVictory(winningGrid);

        // This test should now ideally fail
        Assert.True(result); 
    }
}