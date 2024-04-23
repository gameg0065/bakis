using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2;

public class TickTackToeVictoryTests
{
    [Theory]
    [InlineData(new string[] { "X", "X", "X", "", "", "", "", "", "" }, true)]
    [InlineData(new string[] { "", "", "", "X", "X", "X", "", "", "" }, true)]
    [InlineData(new string[] { "", "", "", "", "", "", "X", "X", "X" }, true)]
    [InlineData(new string[] { "X", "", "", "X", "", "", "X", "", "" }, true)]
    [InlineData(new string[] { "", "X", "", "", "X", "", "", "X", "" }, true)]
    [InlineData(new string[] { "", "", "X", "", "", "X", "", "", "X" }, true)]
    [InlineData(new string[] { "X", "", "", "", "X", "", "", "", "X" }, true)]
    [InlineData(new string[] { "", "", "X", "", "X", "", "X", "", "" }, true)]
    [InlineData(new string[] { "X", "", "", "", "O", "", "", "", "X" }, false)] // Neither X nor O win
    [InlineData(new string[] { "O", "X", "X", "X", "O", "", "", "", "X" }, false)] // X wins diagonally, but O also wins diagonally
    [InlineData(new string[] { "O", "X", "X", "X", "O", "X", "", "", "X" }, true)] // X wins diagonally
    [InlineData(new string[] { "O", "X", "X", "X", "O", "X", "", "", "O" }, true)] // O wins diagonally
    public void CheckVictory_ShouldReturnCorrectly(string[] grid, bool expectedResult)
    {
        // Arrange
        var victoryChecker = new TickTackToeVictory();

        // Act
        var result = victoryChecker.CheckVictory(grid);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}