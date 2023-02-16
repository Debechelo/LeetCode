using System.Collections.Generic;
using Sudok;


public class Program {
    public static void Main(string[] args) {
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

        char[][] board1 = {
            new char[] {'.','.','9','7','4','8','.','.','.' },
            new char[] {'7','.','.','.','.','.','.','.','.' },
            new char[] {'.','2','.','1','.','9','.','.','.' },
            new char[] {'.','.','7','.','.','.','2','4','.' },
            new char[] {'.','6','4','.','1','.','5','9','.' },
            new char[] {'.','9','8','.','.','.','3','.','.' },
            new char[] {'.','.','.','8','.','3','.','2','.' },
            new char[] {'.','.','.','.','.','.','.','.','6' },
            new char[] {'.','.','.','2','7','5','9','.','.' }};

        //Console.WriteLine(Sudoku.IsValidSudoku(board));
        Sudoku.SolveSudoku(board1);
        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++) {
                Console.Write(board1[i][j]);
            }
            Console.WriteLine();
        }
                
    }

}
    
