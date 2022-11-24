

char[][] board = {
    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
    new char[] {'6','.','.','1','9','5','.','.','.'},
    new char[] {'.','9','8','.','.','.','.','6','.'},
    new char[] {'8','.','.','.','6','.','.','.','3'},
    new char[] {'4','.','.','8','.','3','.','.','1'},
    new char[] {'7','.','.','.','2','.','.','.','6'},
    new char[] {'.','6','.','.','.','.','2','8','.'},
    new char[] {'.','.','.','4','1','9','.','.','5'},
    new char[] {'.','.','.','.','8','.','.','7','9'} };

bool flag = false;
{
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    flag = checkingRow(board[i][j], i, j) || flag;
                    if (flag) break;
                    flag = checkingColumn(board[i][j], i, j) || flag;
                    if (flag) break;
                    flag = checkingCell3x3(board[i][j], i, j) || flag;
                    if (flag) break;
                }
            }
            if (flag) break;
        }

        Console.WriteLine(!flag);

        bool checkingRow(char cell, int i, int j)
        {
            for (int k = 0; k < 9; k++)
            {
                if (k != j)
                    if (cell == board[i][k])
                        return true;
            }
            return false;
        }

        bool checkingColumn(char cell, int i, int j)
        {
            for (int k = 0; k < 9; k++)
            {
                if (k != i)
                    if (cell == board[k][j])
                        return true;
            }
            return false;
        }

        bool checkingCell3x3(char cell, int i, int j)
        {
            int i1, i2, j1, j2;

            if (i % 3 == 0){ i1 = i + 1; i2 = i + 2;}
            else if (i % 3 == 1){ i1 = i - 1; i2 = i + 1;}
            else{ i1 = i - 1; i2 = i - 2;}

            if (j % 3 == 0) { j1 = j + 1; j2 = j + 2; }
            else if (j % 3 == 1) { j1 = j - 1; j2 = j + 1; }
            else { j1 = j - 1; j2 = j - 2; }

            int ki = iBorder;
            if (cell == board[i1][j1]) return true; 
            if (cell == board[i1][j2]) return true; 
            if (cell == board[i2][j1]) return true; 
            if (cell == board[i2][j2]) return true;

            return false;
        }
    }
}
