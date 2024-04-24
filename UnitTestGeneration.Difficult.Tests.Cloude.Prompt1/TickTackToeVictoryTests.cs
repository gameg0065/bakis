using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class TickTackToeVictoryTests
{
    [Theory]
    [InlineData(new string[] { "X", "X", "X", " ", " ", " ", " ", " ", " " }, true)]
    [InlineData(new string[] { " ", " ", " ", "X", "X", "X", " ", " ", " " }, true)]
    [InlineData(new string[] { " ", " ", " ", " ", " ", " ", "X", "X", "X" }, true)]
    [InlineData(new string[] { "X", " ", " ", "X", " ", " ", "X", " ", " " }, true)]
    [InlineData(new string[] { " ", "X", " ", " ", "X", " ", " ", "X", " " }, true)]
    [InlineData(new string[] { " ", " ", "X", " ", " ", "X", " ", " ", "X" }, true)]
    [InlineData(new string[] { "X", " ", " ", " ", "X", " ", " ", " ", "X" }, true)]
    [InlineData(new string[] { " ", " ", "X", " ", "X", " ", "X", " ", " " }, true)]
    [InlineData(new string[] { "O", "X", "X", "X", "O", "O", " ", " ", " " }, false)]
    [InlineData(new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " " }, false)]
    public void CheckVictory_ShouldReturnCorrectResult(string[] grid, bool expected)
    {
        // Arrange
        var tickTackToeVictory = new TickTackToeVictory();

        // Act
        bool result = tickTackToeVictory.CheckVictory(grid);

        // Assert
        Assert.Equal(expected, result);
    }
}