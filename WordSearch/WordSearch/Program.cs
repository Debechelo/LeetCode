public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(1);
    }

    public bool Exist(char[][] board, string word)
    {
        bool flag = true;
        foreach (char ch in word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (ch == board[i][j]) {
                        break;
                    }
                }
            }
        }
        return flag;
    }
}
