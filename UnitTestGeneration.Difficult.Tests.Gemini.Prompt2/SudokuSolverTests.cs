using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt2;

public class SudokuSolverTests
{
    [Fact]
    public void FindEmpty_ReturnsFirstEmptyCell()
    {
        int[][] testBoard = {
            new int[] { 0, 1, 2, 0 },
            new int[] { 3, 4, 0, 6 },
            // ...
        };

        var expected = new int[] { 0, 0 }; // Coordinates of the first empty cell
        var result = SudokuSolver.FindEmpty(testBoard);

        Assert.Equal(expected, result);
    }
    
    
}