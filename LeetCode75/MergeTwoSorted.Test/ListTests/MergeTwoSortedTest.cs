namespace LeetCode75.Test.ListTests
{
    [TestClass]
    public class MergeTwoSortedTest
    {
        [TestMethod]
        public void MergeTwoSorted00()
        {
            ListNode list1 = new ListNode();
            ListNode list2 = new ListNode();
            List list = new List();
            ListNode listNode = list.MergeTwoLists(list1, list2);

            int[] listArray = { listNode.val, listNode.next.val };
            int[] listArrayExpected = { 0, 0 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }

        [TestMethod]
        public void MergeTwoSortedNulls()
        {
            ListNode list1 = null;
            ListNode list2 = null;
            List list = new List();
            ListNode listNode = list.MergeTwoLists(list1, list2);

            Assert.IsNull(listNode);
        }

        [TestMethod]
        public void MergeTwoSorted_null_List()
        {
            ListNode list1 = null;
            ListNode list2 = new ListNode(1, new ListNode(4));
            List list = new List();
            ListNode listNode = list.MergeTwoLists(list1, list2);

            int[] listArray = { listNode.val, listNode.next.val };
            int[] listArrayExpected = { 1, 4 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }

        [TestMethod]
        public void MergeTwoSorted_List_null()
        {
            ListNode list2 = null;
            ListNode list1 = new ListNode(1, new ListNode(4));
            List list = new List();
            ListNode listNode = list.MergeTwoLists(list1, list2);

            int[] listArray = { listNode.val, listNode.next.val };
            int[] listArrayExpected = { 1, 4 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }

        [TestMethod]
        public void MergeTwoSortedEqualLength()
        {
            ListNode list2 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list1 = new ListNode(1, new ListNode(3, new ListNode(4)));
            List list = new List();
            ListNode listNode = list.MergeTwoLists(list1, list2);

            int[] listArray = { listNode.val, listNode.next.val, listNode.next.next.val };
            int[] listArrayExpected = { 1, 1, 2, 3, 4, 4 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }

        [TestMethod]
        public void MergeTwoSortedDifferentLength1()
        {
            ListNode list2 = new ListNode(1, new ListNode(5));
            ListNode list1 = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(6))));
            List list = new List();
            ListNode listNode = list.MergeTwoLists(list1, list2);

            int[] listArray = { listNode.val, listNode.next.val, listNode.next.next.val, listNode.next.next.next.val };
            int[] listArrayExpected = { 1, 1, 3, 4, 5, 6 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }

        [TestMethod]
        public void MergeTwoSortedDifferentLength2()
        {
            ListNode list1 = new ListNode(1, new ListNode(5));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(6))));
            List list = new List();
            ListNode listNode = list.MergeTwoLists(list1, list2);

            int[] listArray = { listNode.val, listNode.next.val, listNode.next.next.val, listNode.next.next.next.val };
            int[] listArrayExpected = { 1, 1, 3, 4, 5, 6 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }
    }
}