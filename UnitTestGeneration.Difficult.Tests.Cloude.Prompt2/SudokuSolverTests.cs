using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class SudokuSolverTests
{
[Fact]
    public void FindEmpty_ReturnsNullForFullGrid()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
            new int[] {4, 5, 6, 7, 8, 9, 1, 2, 3},
            new int[] {7, 8, 9, 1, 2, 3, 4, 5, 6},
            new int[] {2, 1, 4, 3, 6, 5, 8, 9, 7},
            new int[] {3, 6, 5, 8, 7, 4, 2, 1, 9},
            new int[] {8, 9, 7, 2, 1, 3, 6, 4, 5},
            new int[] {5, 3, 1, 6, 4, 7, 9, 2, 8},
            new int[] {6, 4, 2, 9, 3, 8, 5, 7, 1},
            new int[] {9, 7, 8, 5, 1, 2, 3, 6, 4}
        };

        // Act
        int[]? result = SudokuSolver.FindEmpty(grid);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void FindEmpty_ReturnsCorrectEmptyCell()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] {0, 1, 0, 2, 0, 0, 0, 0, 4},
            new int[] {5, 0, 0, 9, 0, 0, 0, 1, 0},
            new int[] {0, 6, 4, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0, 6, 0, 4, 0},
            new int[] {2, 0, 0, 0, 0, 7, 0, 3, 0},
            new int[] {6, 0, 7, 0, 0, 8, 0, 0, 5},
            new int[] {7, 0, 0, 3, 0, 0, 0, 5, 0},
            new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {1, 0, 0, 0, 0, 2, 8, 0, 0}
        };

        // Act
        int[]? result = SudokuSolver.FindEmpty(grid);

        // Assert
        Assert.Equal(new int[] { 0, 0 }, result);
    }

    [Theory]
    [InlineData(1, 0, 0, true)]
    [InlineData(0, 1, 1, false)]
    [InlineData(0, 2, 5, false)]
    [InlineData(1, 3, 9, false)]
    [InlineData(2, 0, 8, false)]
    [InlineData(2, 2, 4, false)]
    [InlineData(3, 5, 6, false)]
    [InlineData(4, 1, 7, false)]
    [InlineData(4, 3, 3, false)]
    [InlineData(5, 0, 6, false)]
    [InlineData(5, 5, 8, false)]
    [InlineData(5, 8, 5, false)]
    [InlineData(6, 0, 7, false)]
    [InlineData(6, 6, 2, false)]
    [InlineData(7, 7, 9, true)]
    [InlineData(8, 0, 1, false)]
    [InlineData(8, 5, 2, false)]
    [InlineData(8, 7, 6, false)]
    public void IsPossible_ReturnsCorrectResult(int row, int col, int num, bool expected)
    {
        // Arrange
        int[][] grid = SudokuSolver.board;
        int[] arr = { row, col };

        // Act
        bool result = SudokuSolver.IsPossible(grid, arr, num);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SolveTheGrid_SolvesValidGrid()
    {
        // Arrange
        int[][] grid = new int[][]
        {
            new int[] {0, 1, 0, 2, 0, 0, 0, 0, 4},
            new int[] {5, 0, 0, 9, 0, 0, 0, 1, 0},
            new int[] {0, 6, 4, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0, 6, 0, 4, 0},
            new int[] {2, 0, 0, 0, 0, 7, 0, 3, 0},
            new int[] {6, 0, 7, 0, 0, 8, 0, 0, 5},
            new int[] {7, 0, 0, 3, 0, 0, 0, 5, 0},
            new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {1, 0, 0, 0, 0, 2, 8, 0, 0}
        };

        int[][] expectedGrid = new int[][]
        {
            new int[] {8, 1, 6, 2, 5, 3, 7, 9, 4},
            new int[] {5, 3, 2, 9, 7, 4, 6, 1, 8},
            new int[] {9, 6, 4, 1, 8, 7, 5, 3, 2},
            new int[] {1, 5, 3, 8, 2, 6, 9, 4, 7},
            new int[] {2, 4, 8, 5, 9, 7, 1, 3, 6},
            new int[] {6, 9, 7, 4, 3, 8, 2, 1, 5},
            new int[] {7, 8, 1, 3, 6, 5, 4, 2, 9},
            new int[] {4, 2, 5, 7, 1, 9, 3, 8, 1},
            new int[] {3, 7, 9, 6, 4, 2, 8, 5, 1}
        };

        // Act
        bool result = SudokuSolver.SolveTheGrid(grid);

        // Assert
        Assert.True(result);
        Assert.Equal(expectedGrid, SudokuSolver.board);
    }
}