namespace WordSearch.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            char [][]board = {
                new char[]{'A', 'B', 'C', 'E'},
                new char[]{'S','F','C','S'},
                new char[]{'A','D','E','E'}};
            string word = "ABCCED";

            Program p = new Program();

            Assert.IsTrue(p.Exist(board, word));
        }

        [TestMethod]
        public void TestMethod2()
        {
            char[][] board = {
                new char[]{'A', 'B', 'C', 'E'},
                new char[]{'S','F','C','S'},
                new char[]{'A','D','E','E'}};
            string word = "SEE";

            Program p = new Program();

            Assert.IsTrue(p.Exist(board, word));
        }

        [TestMethod]
        public void TestMethod3()
        {
            char[][] board = {
                new char[]{'A', 'B', 'C', 'E'},
                new char[]{'S','F','C','S'},
                new char[]{'A','D','E','E'}};
            string word = "ABCB";

            Program p = new Program();

            Assert.IsFalse(p.Exist(board, word));
        }
    }
}



