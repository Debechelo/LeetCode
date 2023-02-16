internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
    }

    public static bool SearchMatrix(int[][] matrix, int target) {
        int downBorder = 0;
        int upBorder = matrix.Length * matrix[0].Length - 1;
        while(downBorder <= upBorder) {
            int mid = downBorder + (upBorder - downBorder) / 2;
            int i = mid / matrix[0].Length;
            int j = mid % matrix[0].Length;
            if(matrix[i][j] == target)
                return true;
            else if(matrix[i][j] < target)
                downBorder = mid + 1;
            else
                upBorder = mid - 1;
        }
        return false;
    }
}