namespace UnitTestGeneration.Difficult.App;
// https://github.com/TheCodersCat/C-Sharp-Tic-Tac-Toe/blob/main/TicTacToe/TicTacToe/Program.cs
// cy = 16, co = 9
public class TickTackToeVictory
{
    public bool CheckVictory(string[] grid)
    {
        bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
        bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
        bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
        bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
        bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
        bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
        bool diagDown = grid[0] == grid[4] && grid[4] == grid[8];
        bool diagUp = grid[6] == grid[4] && grid[4] == grid[2];

        return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
    }
}