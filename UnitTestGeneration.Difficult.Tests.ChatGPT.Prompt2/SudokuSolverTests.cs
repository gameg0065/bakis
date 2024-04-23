using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2;

public class SudokuSolverTests
{
[Fact]
    public void SolveTheGrid_ShouldReturnTrueForValidInput()
    {
        // Arrange
        int[][] board = new int[][]
        {
            new int[] {5, 1, 0, 2, 0, 0, 0, 0, 4},
            new int[] {0, 0, 0, 9, 0, 0, 0, 1, 0},
            new int[] {0, 6, 4, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0, 6, 0, 4, 0},
            new int[] {2, 0, 0, 0, 0, 7, 0, 3, 0},
            new int[] {6, 0, 7, 0, 0, 8, 0, 0, 5},
            new int[] {7, 0, 0, 3, 0, 0, 0, 5, 0},
            new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {1, 0, 0, 0, 0, 2, 8, 0, 0}
        };

        // Act
        bool result = SudokuSolver.SolveTheGrid(board);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void FindEmpty_ShouldReturnCorrectCoordinatesWhenEmptyCellExists()
    {
        // Arrange
        int[][] board = new int[][]
        {
            new int[] {5, 1, 0, 2, 0, 0, 0, 0, 4},
            new int[] {0, 0, 0, 9, 0, 0, 0, 1, 0},
            new int[] {0, 6, 4, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0, 6, 0, 4, 0},
            new int[] {2, 0, 0, 0, 0, 7, 0, 3, 0},
            new int[] {6, 0, 7, 0, 0, 8, 0, 0, 5},
            new int[] {7, 0, 0, 3, 0, 0, 0, 5, 0},
            new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {1, 0, 0, 0, 0, 2, 8, 0, 0}
        };

        // Act
        int[]? result = SudokuSolver.FindEmpty(board);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(0, result?[0]);
        Assert.Equal(2, result?[1]);
    }

    [Fact]
    public void FindEmpty_ShouldReturnNullWhenNoEmptyCellExists()
    {
        // Arrange
        int[][] board = new int[][]
        {
            new int[] {5, 1, 3, 2, 7, 6, 9, 8, 4},
            new int[] {8, 2, 6, 9, 4, 5, 7, 1, 3},
            new int[] {9, 6, 4, 8, 1, 3, 2, 7, 5},
            new int[] {3, 7, 5, 1, 2, 6, 8, 4, 9},
            new int[] {2, 8, 1, 5, 9, 7, 6, 3, 4},
            new int[] {6, 4, 7, 8, 3, 9, 1, 2, 5},
            new int[] {7, 3, 2, 4, 8, 1, 9, 5, 6},
            new int[] {4, 5, 8, 6, 1, 2, 3, 9, 7},
            new int[] {1, 9, 3, 7, 5, 2, 8, 6, 4}
        };

        // Act
        int[]? result = SudokuSolver.FindEmpty(board);

        // Assert
        Assert.Null(result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 2, 0, 0, 0, 0, 7, 0, 3, 0 }, 1, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 2, 0, 0, 0, 0, 7, 0, 3, 0 }, 2, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 2, 0, 0, 0, 0, 7, 0, 3, 0 }, 6, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 2, 0, 0, 0, 0, 7, 0, 3, 0 }, 7, false)]
    public void IsPossible_ShouldReturnCorrectly(int[] row, int[] arr, int num, bool expected)
    {
        // Act
        bool result = SudokuSolver.IsPossible(new int[][] { row }, arr, num);

        // Assert
        Assert.Equal(expected, result);
    }
}