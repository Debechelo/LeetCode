namespace Data_Structure;
internal class Matrix {

    // Измените форму матрицы 566
    public int[][] MatrixReshape(int[][] mat, int row, int column) {
        if(mat.Length * mat[0].Length != row * column)
            return mat;
        int[][] resh = new int[row][];

        int k = 0, l = 0;
        for(int i = 0; i < mat.Length; i++) {
            for(int j = 0; j < mat[0].Length; j++) {
                if(l == 0)
                    resh[k] = new int[column];

                resh[k][l] = mat[i][j];
                l++;
                if(l == column) {
                    k++;
                    l = 0;
                }
            }
        }
        return resh;
    }

    // Pascal's Triangle 118
    public IList<IList<int>> Generate(int numRows) {
        var res = new List<IList<int>>(numRows) {
            new List<int>(1) { 1 }
        };
        for(int i = 1; i < numRows; i++) {
            res.Add(new List<int>(i + 1) { 1 });
            for(int j = 1; j < i; j++) {
               res[i].Add(res[i - 1][j - 1] + res[i - 1][j]);
            }
            res[i].Add(1);
        }
        return res;
    }
}
