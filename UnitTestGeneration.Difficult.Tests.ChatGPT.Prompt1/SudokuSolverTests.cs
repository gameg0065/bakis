using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1;

public class SudokuSolverTests
{
    [Fact]
    public void SolveTheGrid_ShouldSolveValidSudoku()
    {
        // Arrange
        int[][] board = new int[][]
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
        bool solved = SudokuSolver.SolveTheGrid(board);

        // Assert
        Assert.True(solved);

        // Check if the board is solved
        Assert.True(IsSolved(board));
    }

    private bool IsSolved(int[][] board)
    {
        foreach (var row in board)
        {
            foreach (var cell in row)
            {
                if (cell == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}