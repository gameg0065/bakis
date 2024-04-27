using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class TickTackToeVictoryTests
{
    [Fact]
    public void CheckVictory_EmptyGrid_ReturnsFalse()
    {
        // Arrange
        var game = new TickTackToeVictory();
        string[] emptyGrid = new string[9];

        // Act
        bool result = game.CheckVictory(emptyGrid);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckVictory_RowVictory_ReturnsTrue()
    {
        // Arrange
        var game = new TickTackToeVictory();
        string[] grid = { "X", "X", "X", "-", "-", "-", "-", "-", "-" };

        // Act
        bool result = game.CheckVictory(grid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckVictory_ColumnVictory_ReturnsTrue()
    {
        // Arrange
        var game = new TickTackToeVictory();
        string[] grid = { "X", "-", "-", "X", "-", "-", "X", "-", "-" };

        // Act
        bool result = game.CheckVictory(grid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckVictory_DiagonalDownVictory_ReturnsTrue()
    {
        // Arrange
        var game = new TickTackToeVictory();
        string[] grid = { "X", "-", "-", "-", "X", "-", "-", "-", "X" };

        // Act
        bool result = game.CheckVictory(grid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckVictory_DiagonalUpVictory_ReturnsTrue()
    {
        // Arrange
        var game = new TickTackToeVictory();
        string[] grid = { "-", "-", "X", "-", "X", "-", "X", "-", "-" };

        // Act
        bool result = game.CheckVictory(grid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckVictory_NoVictory_ReturnsFalse()
    {
        // Arrange
        var game = new TickTackToeVictory();
        string[] grid = { "X", "O", "X", "O", "X", "O", "X", "O", "X" };

        // Act
        bool result = game.CheckVictory(grid);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckVictory_InvalidGridLength_ThrowsArgumentException()
    {
        // Arrange
        var game = new TickTackToeVictory();
        string[] invalidGrid = new string[10]; // Invalid grid length

        // Act & Assert
        Assert.Throws<ArgumentException>(() => game.CheckVictory(invalidGrid));
    }
}