using System.Collections;

namespace DataStructure.Test.ListTests
{
    [TestClass]
    public class RemoveNthFromEndTest {

        [TestMethod]
        public void RemoveNthFromEndNull()
        {
            ListNode listNode = null;
            int n = 1;
            List list = new List();
            ListNode head = list.RemoveNthFromEnd(listNode, n);

            Assert.IsNull(head);
        }

        [TestMethod]
        public void RemoveNthFromEndOnelength()
        {
            ListNode listNode = new ListNode(3);
            int n = 1;
            List list = new List();
            ListNode head = list.RemoveNthFromEnd(listNode, n);

            Assert.IsNull(head);
        }

        [TestMethod]
        public void RemoveNthFromEndEnd()
        {
            ListNode listNode = new ListNode(3, new ListNode(4, new ListNode(5)));
            int n = 1;
            List list = new List();
            ListNode head = list.RemoveNthFromEnd(listNode, n);

            int[] listArray = {3, 4};

            for(int i = 0; i < listArray.Length; i++) {
                Assert.AreEqual(listArray[i], head.val);
                head = head.next;
            }
        }

        [TestMethod]
        public void RemoveNthFromEndMiddle()
        {
            ListNode listNode = new ListNode(3, new ListNode(4, new ListNode(5)));
            int n = 2;
            List list = new List();
            ListNode head = list.RemoveNthFromEnd(listNode, n);

            int[] listArray = { 3, 5 };

            for(int i = 0; i < listArray.Length; i++) {
                Assert.AreEqual(listArray[i], head.val);
                head = head.next;
            }
        }

        [TestMethod]
        public void RemoveNthFromEndBegin() {
            ListNode listNode = new ListNode(3, new ListNode(4, new ListNode(5)));
            int n = 3;
            List list = new List();
            ListNode head = list.RemoveNthFromEnd(listNode, n);

            int[] listArray = { 4, 5 };

            for(int i = 0; i < listArray.Length; i++) {
                Assert.AreEqual(listArray[i], head.val);
                head = head.next;
            }
        }
    }
}
