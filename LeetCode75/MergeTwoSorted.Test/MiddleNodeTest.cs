namespace LeetCode75.Test
{
    [TestClass]
    public class MiddleNodeTest
    {
        [TestMethod]
        public void MiddleNodeNull()
        {
            ListNode listNode1 = null;
            List list = new List();
            ListNode listNode = list.MiddleNode(listNode1);

            Assert.IsNull(listNode);
        }

        [TestMethod]
        public void MiddleNodeOneLength()
        {
            ListNode listNode1 = new ListNode(3);
            List list = new List();
            ListNode listNode = list.MiddleNode(listNode1);

            Assert.AreEqual(3, listNode.val);
        }

        [TestMethod]
        public void MiddleNodeTwoLength()
        {
            ListNode listNode1 = new ListNode(1, new ListNode(3));
            List list = new List();
            ListNode listNode = list.MiddleNode(listNode1);

            Assert.AreEqual(3, listNode.val);
        }

        [TestMethod]
        public void MiddleNode2nLength()
        {
            ListNode listNode1 = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(6,
                new ListNode(7, new ListNode(9))))));
            List list = new List();
            ListNode listNode = list.MiddleNode(listNode1);

            int[] listArray = { listNode.val, listNode.next.val, listNode.next.next.val };
            int[] listArrayExpected = { 6, 7, 9 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }

        [TestMethod]
        public void MiddleNode2nplus1Length()
        {
            ListNode listNode1 = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(6,
                new ListNode(7)))));
            List list = new List();
            ListNode listNode = list.MiddleNode(listNode1);

            int[] listArray = { listNode.val, listNode.next.val, listNode.next.next.val };
            int[] listArrayExpected = { 4, 6, 7 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }
    }
}
