public class Solution
{
    //static void Main()
    //{
    //    char[][] board = new char[9][];

    //    board[0] = new[] { '.', '.', '.', '.', '5', '.', '.', '1', '.' };
    //    board[1] = new[] { '.', '4', '.', '3', '.', '.', '.', '.', '.' };
    //    board[2] = new[] { '.', '.', '.', '.', '.', '3', '.', '.', '1' };
    //    board[3] = new[] { '8', '.', '.', '.', '.', '.', '.', '2', '.' };
    //    board[4] = new[] { '.', '.', '2', '.', '7', '.', '.', '.', '.' };
    //    board[5] = new[] { '.', '1', '5', '.', '.', '.', '.', '.', '.' };
    //    board[6] = new[] { '.', '.', '.', '.', '.', '2', '.', '.', '.' };
    //    board[7] = new[] { '.', '2', '.', '9', '.', '.', '.', '.', '.' };
    //    board[8] = new[] { '.', '.', '4', '.', '.', '.', '.', '.', '.' };

    //    Console.WriteLine(IsValidSudoku(board));
    //}

    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (!RowChecker(i, board))
            {
                return false;
            }

            if (!ColumnChecker(i, board))
            {
                return false;
            }
        }

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if ((i + 1) % 3 != 0 || (j + 1) % 3 != 0) continue;

                if (!SquareChecker(i, j, board))
                {
                    return false;
                }
            }
        }

        return true;
    }

    private bool RowChecker(int row, char[][] board)
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>
        {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 },
            { 6, 0 },
            { 7, 0 },
            { 8, 0 },
            { 9, 0 },
        };

        for (int i = 0; i < board[row].Length; i++)
        {
            if (board[row][i] != '.')
            {
                numbers[board[row][i] - 48]++;
            }
        }

        return numbers.All(x => x.Value <= 1);
    }

    private bool ColumnChecker(int column, char[][] board)
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>
        {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 },
            { 6, 0 },
            { 7, 0 },
            { 8, 0 },
            { 9, 0 },
        };

        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i][column] != '.')
            {
                numbers[board[i][column] - 48]++;
            }
        }

        return numbers.All(x => x.Value <= 1);
    }

    private bool SquareChecker(int row, int column, char[][] board)
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>
        {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 },
            { 6, 0 },
            { 7, 0 },
            { 8, 0 },
            { 9, 0 },
        };

        for (int i = row - 2; i <= row; i++)
        {
            for (int j = column - 2; j <= column; j++)
            {
                if (board[i][j] != '.')
                {
                    numbers[board[i][j] - 48]++;
                }
            }
        }

        return numbers.All(x => x.Value <= 1);
    }
}