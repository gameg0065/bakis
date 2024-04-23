using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class SudokuSolverTests
{
    [Fact]
    public void SolveTheGrid_ShouldReturnTrueForSolvedGrid()
    {
        // Arrange
        int[][] grid = new int[9][]
        {
            new int[] {5, 1, 8, 2, 7, 3, 9, 6, 4},
            new int[] {5, 3, 2, 9, 6, 4, 7, 1, 8},
            new int[] {9, 6, 4, 8, 1, 5, 3, 7, 2},
            new int[] {1, 2, 3, 7, 9, 6, 5, 4, 8},
            new int[] {2, 5, 6, 4, 8, 7, 1, 3, 9},
            new int[] {6, 4, 7, 1, 3, 8, 2, 9, 5},
            new int[] {7, 8, 9, 3, 2, 1, 6, 5, 4},
            new int[] {4, 9, 5, 6, 4, 8, 7, 2, 3},
            new int[] {1, 7, 3, 5, 9, 2, 8, 4, 6}
        };

        // Act
        bool result = SudokuSolver.SolveTheGrid(grid);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SolveTheGrid_ShouldReturnFalseForUnsolvableGrid()
    {
        // Arrange
        int[][] grid = new int[9][]
        {
            new int[] {5, 1, 8, 2, 7, 3, 9, 6, 4},
            new int[] {5, 3, 2, 9, 6, 4, 7, 1, 8},
            new int[] {9, 6, 4, 8, 1, 5, 3, 7, 2},
            new int[] {1, 2, 3, 7, 9, 6, 5, 4, 8},
            new int[] {2, 5, 6, 4, 8, 7, 1, 3, 9},
            new int[] {6, 4, 7, 1, 3, 8, 2, 9, 5},
            new int[] {7, 8, 9, 3, 2, 1, 6, 5, 4},
            new int[] {4, 9, 5, 6, 4, 8, 7, 2, 3},
            new int[] {1, 7, 3, 5, 9, 2, 8, 4, 4} // Invalid, two 4s in the last row
        };

        // Act
        bool result = SudokuSolver.SolveTheGrid(grid);

        // Assert
        Assert.False(result);
    }
}