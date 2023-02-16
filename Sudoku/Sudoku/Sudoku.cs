using System;

namespace Sudok;

class EmptyCell {
    public EmptyCell() {
        posibleNum = new HashSet<int>();
        cellRows = new Dictionary<int, HashSet<int>>(9);
        cellColumns = new Dictionary<int, HashSet<int>>(9);
        cell3x3s = new Dictionary<int, HashSet<int>>(9);
    }

    public HashSet<int> posibleNum;
    public Dictionary<int, HashSet<int>> cellRows;
    public Dictionary<int, HashSet<int>> cellColumns;
    public Dictionary<int, HashSet<int>> cell3x3s;
}

internal class Sudoku {

    public static void SolveSudoku(char[][] board) {
        var chars = new HashSet<int>[3,9];
        var emptyCells = new List<EmptyCell>();
        Dictionary<int, HashSet<int>> cellRows;
        Dictionary<int, HashSet<int>> cellColumns;
        Dictionary<int, HashSet<int>> cell3x3s;

        for(int i = 0; i < 9; i++) {
            if(!AddRowAndColumn(i))
                return;
            if(!AddCell3x3(i))
                return;
        }

        int count = 0;
        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++) {
                if(board[i][j] == '.') {
                    emptyCells.Add(new EmptyCell());
                    int cellInd = i / 3 * 3 + j / 3;
                    for(int k = 1; k < 10; k++) {
                        if(chars[0, i].Contains(k) || chars[1, j].Contains(k)
                            || chars[2, cellInd].Contains(k))
                            continue;
                        else {
                            emptyCells[0].posibleNum.Add(k);
                            emptyCells[0].cellColumns.Add(k,k);
                        }
                    }
                }
            }
        }
        chars = null;

        bool flag = true;
        while(flag) {
            flag= false;
            for(int i = 0; i < 9; i++) {
                FindPosibleElem(i);
                for(int j = 0; j < 9; j++) {
                    if(emptyCells[i, j] != null && emptyCells[i, j].Count == 1) {
                        foreach(int item in emptyCells[i, j]) {
                            SetFoundElement(i, j, item);;
                        }
                        flag = true;
                    }
                }
            }
        }

        void FindPosibleElem(int i) {
            int count = 0;
            for(int k = 1; k < 10; k++) {
                count = 0;
                int p = 0;
                for(int l = 0; l < 9; l++) {
                    if(board[i][l] == '.' && emptyCells[i, l].Contains(k)) {
                        count++;
                        if(count > 1)
                            break;
                        p = l;
                    }
                }
                if(count == 1)
                    SetFoundElement(i, p, k);

                count = 0;
                p = 0;
                for(int l = 0; l < 9; l++) {
                    if(board[l][i] == '.' && emptyCells[l, i].Contains(k)) {
                        count++;
                        if(count > 1)
                            break;
                        p = l;
                    }
                }
                if(count == 1)
                    SetFoundElement(p, i, k);


                int row = i / 3 * 3;
                int column = i % 3 * 3;
                count = 0;
                p = 0;
                int p1 = 0;
                for(int l = 0; l < 9; l++) {
                    if(board[row][column] == '.' && emptyCells[row, column].Contains(k)) {
                        count++;
                        if(count > 1)
                            break;
                        p = row;
                        p1 = column;
                    }
                }
                if(count == 1)
                    SetFoundElement(p, p1, k);
            }
        }



        void SetFoundElement(int i , int j, int num) {
            board[i][j] = (char)(num + 48);
            emptyCells[i, j] = null;

            int cellInd = i / 3 * 3 + j / 3;
            int i2 = cellInd / 3 * 3;
            int j2 = cellInd % 3 * 3;
            for(int l = 0; l < 9; l++) {
                if(board[i][l] == '.' && emptyCells[i, l].Contains(num)) {
                    emptyCells[i, l].Remove(num);
                }
                if(board[l][j] == '.' && emptyCells[l, j].Contains(num)) {
                    emptyCells[l, j].Remove(num);
                }
                if(board[i2][j2] == '.' && emptyCells[i2, j2].Contains(num)) {
                    emptyCells[i2, j2].Remove(num);
                }
                if((++j2) % 3 == 0) {
                    i2++;
                    j2 -= 3;
                }
            }
        }


        bool AddRowAndColumn(int i) {
            chars[0, i] = new HashSet<int>(9);
            chars[1, i] = new HashSet<int>(9);
            for(int j = 0; j < 9; j++) {
                if(board[i][j] != '.') {
                    if(chars[0, i].Contains(board[i][j] - '0'))
                        return false;
                    else
                        chars[0, i].Add(board[i][j] - '0');
                }
                if(board[j][i] != '.') {
                    if(chars[1, i].Contains(board[j][i] - '0'))
                        return false;
                    else
                        chars[1, i].Add(board[j][i] - '0');
                }
            }
            return true;
        }

        bool AddCell3x3(int k) {
            chars[2, k] = new HashSet<int>(9);
            int row = k / 3 * 3;
            int column = k % 3 * 3;
            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 3; j++) {
                    if(board[row + i][column + j] != '.') {
                        if(chars[2, k].Contains(board[row + i][column + j] - '0'))
                            return false;
                        else
                            chars[2, k].Add(board[row + i][column + j] - '0');
                    }
                }
            }
            return true;
        }
    }


    public static bool IsValidSudoku(char[][] board) {
        var set1 = new HashSet<char>(9);
        var set2 = new HashSet<char>(9);
        var set3 = new HashSet<char>(9);
        for(int i = 0; i < 9; i++) {
            if(checkingRowAndColumn(set1, set2, i))
                return false;
            if(checkingCell3x3(set3, i))
                return false;
            set1.Clear();
            set2.Clear();
            set3.Clear();
        }
        return true;

        bool checkingRowAndColumn(HashSet<char> set1, HashSet<char> set2, int i) {
            for(int j = 0; j < 9; j++) {
                if(board[i][j] != '.') {
                    if(set1.Contains(board[i][j]))
                        return true;
                    else
                        set1.Add(board[i][j]);
                }
                if(board[j][i] != '.') {
                    if(set2.Contains(board[j][i]))
                        return true;
                    else
                        set2.Add(board[j][i]);
                }
            }
            return false;
        }

        bool checkingCell3x3(HashSet<char> set, int k) {
            int row = k / 3 * 3;
            int column = k % 3 * 3;
            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 3; j++) {
                    if(board[row + i][column + j] != '.') {
                        if(set.Contains(board[row + i][column + j]))
                            return true;
                        else
                            set.Add(board[row + i][column + j]);
                    }
                }
            }
            return false;
        }
    }
}
