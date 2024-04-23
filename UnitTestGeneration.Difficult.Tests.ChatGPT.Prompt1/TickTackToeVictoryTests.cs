using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1;

public class TickTackToeVictoryTests
{
    [Fact]
    public void CheckVictory_ShouldReturnTrue_WhenRow1IsFilledWithSameSymbol()
    {
        // Arrange
        var victoryChecker = new TickTackToeVictory();
        string[] grid = { "X", "X", "X", "O", "", "O", "O", "", "X" };

        // Act
        bool isVictory = victoryChecker.CheckVictory(grid);

        // Assert
        Assert.True(isVictory);
    }

    [Fact]
    public void CheckVictory_ShouldReturnTrue_WhenCol2IsFilledWithSameSymbol()
    {
        // Arrange
        var victoryChecker = new TickTackToeVictory();
        string[] grid = { "O", "X", "", "O", "X", "", "O", "X", "" };

        // Act
        bool isVictory = victoryChecker.CheckVictory(grid);

        // Assert
        Assert.True(isVictory);
    }

    [Fact]
    public void CheckVictory_ShouldReturnTrue_WhenDiagDownIsFilledWithSameSymbol()
    {
        // Arrange
        var victoryChecker = new TickTackToeVictory();
        string[] grid = { "X", "O", "O", "O", "X", "X", "O", "X", "X" };

        // Act
        bool isVictory = victoryChecker.CheckVictory(grid);

        // Assert
        Assert.True(isVictory);
    }

    [Fact]
    public void CheckVictory_ShouldReturnFalse_WhenNoVictoryCondition()
    {
        // Arrange
        var victoryChecker = new TickTackToeVictory();
        string[] grid = { "X", "O", "X", "O", "X", "O", "O", "X", "O" };

        // Act
        bool isVictory = victoryChecker.CheckVictory(grid);

        // Assert
        Assert.False(isVictory);
    }
}