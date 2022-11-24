﻿using LeetCode75;
using System.Security.Principal;

namespace LeetCode75.Test
{
    [TestClass]
    public class ReverseListTest
    {
        [TestMethod]
        public void ReverseListNull()
        {
            ListNode head = null;
            MergeTwoSortedLists mtsl = new MergeTwoSortedLists();
            ListNode reverseHead = mtsl.ReverseList(head);
            Assert.IsNull(reverseHead);
        }

        [TestMethod]
        public void ReverseList0()
        {
            ListNode head = new ListNode();
            MergeTwoSortedLists mtsl = new MergeTwoSortedLists();
            ListNode reverseHead = mtsl.ReverseList(head);
            Assert.AreEqual(0, reverseHead.val);
        }

        [TestMethod]
        public void ReverseListOneLength()
        {
            ListNode head = new ListNode(1);
            MergeTwoSortedLists mtsl = new MergeTwoSortedLists();
            ListNode reverseHead = mtsl.ReverseList(head);
            Assert.AreEqual(1, reverseHead.val);
        }

        [TestMethod]
        public void ReverseListNormalTest()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            MergeTwoSortedLists mtsl = new MergeTwoSortedLists();
            ListNode reverseHead = mtsl.ReverseList(head);
            int[] listArray = { reverseHead.val, reverseHead.next.val, reverseHead.next.next.val , reverseHead.next.next.next.val
                    , reverseHead.next.next.next.next.val };
            int[] listArrayExpected = { 5, 4, 3, 2, 1 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }

        [TestMethod]
        public void ReverseListNormalTest2()
        {
            ListNode head = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))));
            MergeTwoSortedLists mtsl = new MergeTwoSortedLists();
            ListNode reverseHead = mtsl.ReverseList(head);

            int[] listArray = { reverseHead.val, reverseHead.next.val, reverseHead.next.next.val , reverseHead.next.next.next.val 
                    , reverseHead.next.next.next.next.val };
            int[] listArrayExpected = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < listArray.Length; i++)
            {
                Assert.AreEqual(listArray[i], listArrayExpected[i]);
            }
        }
    }
}
