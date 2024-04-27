using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class SudokuSolverTests
{
[Fact]
    public void SolveTheGrid_EmptyGrid_ReturnsFalse()
    {
        // Arrange
        int[][] emptyGrid = new int[9][];
        for (int i = 0; i < 9; i++)
        {
            emptyGrid[i] = new int[9];
        }

        // Act
        bool result = SudokuSolver.SolveTheGrid(emptyGrid);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SolveTheGrid_SolvedGrid_ReturnsTrue()
    {
        // Arrange
        int[][] solvedGrid = new int[9][]
        {
            new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
            new int[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
            new int[] { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
            new int[] { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
            new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
            new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
            new int[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
            new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
            new int[] { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
        };

        // Act
        bool result = SudokuSolver.SolveTheGrid(solvedGrid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void FindEmpty_EmptyGrid_ReturnsNull()
    {
        // Arrange
        int[][] emptyGrid = new int[9][];
        for (int i = 0; i < 9; i++)
        {
            emptyGrid[i] = new int[9];
        }

        // Act
        int[]? result = SudokuSolver.FindEmpty(emptyGrid);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void FindEmpty_PartiallyFilledGrid_ReturnsCorrectPosition()
    {
        // Arrange
        int[][] grid = SudokuSolver.board;

        // Act
        int[]? result = SudokuSolver.FindEmpty(grid);

        // Assert
        Assert.Equal(new int[] { 7, 4 }, result);
    }

    [Fact]
    public void IsPossible_ValidNumber_ReturnsTrue()
    {
        // Arrange
        int[][] grid = SudokuSolver.board;
        int[]? position = new int[] { 0, 2 };
        int number = 3;

        // Act
        bool result = SudokuSolver.IsPossible(grid, position, number);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPossible_InvalidNumberInRow_ReturnsFalse()
    {
        // Arrange
        int[][] grid = SudokuSolver.board;
        int[]? position = new int[] { 0, 2 };
        int number = 1;

        // Act
        bool result = SudokuSolver.IsPossible(grid, position, number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPossible_InvalidNumberInColumn_ReturnsFalse()
    {
        // Arrange
        int[][] grid = SudokuSolver.board;
        int[]? position = new int[] { 0, 2 };
        int number = 2;

        // Act
        bool result = SudokuSolver.IsPossible(grid, position, number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPossible_InvalidNumberInBox_ReturnsFalse()
    {
        // Arrange
        int[][] grid = SudokuSolver.board;
        int[]? position = new int[] { 0, 2 };
        int number = 4;

        // Act
        bool result = SudokuSolver.IsPossible(grid, position, number);

        // Assert
        Assert.False(result);
    }
}