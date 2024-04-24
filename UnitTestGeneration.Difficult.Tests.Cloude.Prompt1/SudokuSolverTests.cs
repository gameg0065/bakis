using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class SudokuSolverTests
{
    [Fact]
    public void FindEmpty_ShouldReturnCorrectEmptyPosition()
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
        int[] expected = new int[] { 7, 0 };

        // Act
        int[]? result = SudokuSolver.FindEmpty(grid);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 0, 0 }, 1, true)]
    [InlineData(new int[] { 0, 0 }, 2, false)]
    [InlineData(new int[] { 0, 1 }, 1, false)]
    [InlineData(new int[] { 0, 1 }, 5, false)]
    public void IsPossible_ShouldReturnCorrectResult(int[] position, int num, bool expected)
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
        bool result = SudokuSolver.IsPossible(grid, position, num);

        // Assert
        Assert.Equal(expected, result);
    }
}