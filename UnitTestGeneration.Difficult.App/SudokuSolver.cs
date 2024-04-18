namespace UnitTestGeneration.Difficult.App;
// https://github.com/Youssef155/PRODIGY_SD_04/blob/master/SudokuSolver/SolvingTheGrid.cs
// cy = 21, co = 33

public static class SudokuSolver
{
    public static int[][] board = [[0, 1, 0, 2, 0, 0, 0, 0, 4],
                                [5, 0, 0, 9, 0, 0, 0, 1, 0],
                                [0, 6, 4, 0, 0, 0, 0, 0, 0],
                                [0, 0, 0, 0, 0, 6, 0, 4, 0],
                                [2, 0, 0, 0, 0, 7, 0, 3, 0],
                                [6, 0, 7, 0, 0, 8, 0, 0, 5],
                                [7, 0, 0, 3, 0, 0, 0, 5, 0],
                                [0, 0, 0, 0, 0, 0, 0, 0, 0],
                                [1, 0, 0, 0, 0, 2, 8, 0, 0]];




        // static void Main(string[] args)
        // {
        //
        //     while (SolveTheGrid(board) == true)
        //     {
        //         SolveTheGrid(board);
        //     }
        //
        //     for (int i = 0; i < 9; i++)
        //     {
        //         for (int j = 0; j < 9; j++)
        //         {
        //             Console.Write(board[i][j] + " , ");
        //             if (j == 8)
        //                 Console.WriteLine();
        //         }
        //     }
        //
        // }

        public static bool SolveTheGrid(int[][] grid)
        {
            if (FindEmpty(grid) == null)
            {
                return false;
            }
            else
            {
                int[]? arr = FindEmpty(grid);
                for (int i = 1; i < 10; i++)
                {
                    if (IsPossible(grid, arr, i))
                    {
                        grid[arr[0]][arr[1]] = i;

                        if (!SolveTheGrid(grid))
                        {
                            
                            return true;
                            
                        }

                        grid[arr[0]][arr[1]] = 0;

                    }
                }
            }
            board = grid;
            return true;
        }


        public static int[]? FindEmpty(int[][] grid)
        {
            int[] arr = [0, 0];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        arr = [i, j];
                        return arr;
                    }
                }
            }
            return null;
        }

        public static bool IsPossible(int[][] grid, int[]? arr, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[arr[0]][i] == num && i != arr[1])
                {
                    return false;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                if (grid[i][arr[1]] == num && i != arr[0])
                {
                    return false;
                }
            }

            for (int i = (arr[0] / 3) * 3; i < (arr[0] / 3) * 3 + 3; i++)
            {
                for (int j = (arr[1] / 3) * 3; j < (arr[1] / 3) * 3 + 3; j++)
                {
                    if (grid[i][j] == num && i != arr[0] && j != arr[1])
                        return false;
                }
            }

            return true;
        }
}