using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class TickTackToeVictoryTests
{
    private readonly TickTackToeVictory _tttVictory;

    public TickTackToeVictoryTests()
    {
        _tttVictory = new TickTackToeVictory();
    }

    [Theory]
    [InlineData(new[] { "X", "X", "X", "", "", "", "", "", "" }, true)]
    [InlineData(new[] { "", "", "", "X", "X", "X", "", "", "" }, true)]
    [InlineData(new[] { "", "", "", "", "", "", "X", "X", "X" }, true)]
    [InlineData(new[] { "X", "", "", "X", "", "", "X", "", "" }, true)]
    [InlineData(new[] { "", "X", "", "", "X", "", "", "X", "" }, true)]
    [InlineData(new[] { "", "", "X", "", "", "X", "", "", "X" }, true)]
    [InlineData(new[] { "X", "", "", "", "X", "", "", "", "X" }, true)]
    [InlineData(new[] { "", "", "X", "", "X", "", "X", "", "" }, true)]
    [InlineData(new[] { "O", "O", "O", "", "", "", "", "", "" }, true)]
    [InlineData(new[] { "", "", "", "O", "O", "O", "", "", "" }, true)]
    [InlineData(new[] { "", "", "", "", "", "", "O", "O", "O" }, true)]
    [InlineData(new[] { "O", "", "", "O", "", "", "O", "", "" }, true)]
    [InlineData(new[] { "", "O", "", "", "O", "", "", "O", "" }, true)]
    [InlineData(new[] { "", "", "O", "", "", "O", "", "", "O" }, true)]
    [InlineData(new[] { "O", "", "", "", "O", "", "", "", "O" }, true)]
    [InlineData(new[] { "", "", "O", "", "O", "", "O", "", "" }, true)]
    // [InlineData(new[] { "", "", "", "", "", "", "", "", "" }, false)]
    // [InlineData(new[] { "X", "O", "X", "O", "X", "O", "X", "O", "X" }, false)]
    public void CheckVictory_ShouldReturnCorrectResult(string[] grid, bool expectedResult)
    {
        // Act
        var result = _tttVictory.CheckVictory(grid);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}