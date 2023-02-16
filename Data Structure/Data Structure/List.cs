using System;
using System;
using System.Globalization;
using System.Xml.Linq;

namespace DataStructure {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }

    public class List {

        //Merge Two Sorted Lists
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            if(list1 == null && list2 == null)
                return null;
            ListNode sortedList = new ListNode();
            ListNode listNode = sortedList;

            while(list1 != null && list2 != null) {
                if(list1.val <= list2.val) {
                    listNode.next = new ListNode(list1.val);
                    list1 = list1.next;
                } else {
                    listNode.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                listNode = listNode.next;
            }
            if(list1 == null)
                listNode.next = list2;
            else if(list2 == null)
                listNode.next = list1;
            return sortedList.next;
        }


        //Merge k Sorted Lists
        public ListNode MergeKLists(ListNode[] lists) {
            if(lists.Length == 0)
                return null;
            if(lists.Length == 1)
                return lists[0];

            double t = lists.Length;
            while(t != 1) {
                t /= 2.0;
                for(int i = 0; i < t; i++) {
                    if(i + 1 <= t)
                        lists[i] = MergeTwoLists(lists[2 * i], lists[2 * i + 1]);
                    else
                        lists[i] = lists[2 * i];
                }
                t = Math.Ceiling(t);

            }
            return lists[0];
        }

        public ListNode ReverseList(ListNode head) {
            if(head == null || head.next == null)
                return head;
            ListNode node = head.next;
            ListNode nextNode = node.next;
            head.next = null;
            while(node != null) {
                nextNode = node.next;
                node.next = head;
                head = node;
                node = nextNode;
            }
            return head;
        }

        public ListNode reverse(ListNode head) {
            if(head == null || head.next == null)
                return head;

            ListNode rest = reverse(head.next);
            head.next.next = head;
            head.next = null;
            return rest;
        }

        public ListNode SwapPairs(ListNode head) {
            ListNode begin = head;

            while(head != null && head.next != null) {
                (head.val, head.next.val) = (head.next.val, head.val);
                head = head.next.next;
            }

            return begin;
        }

        public ListNode ReverseKGroup(ListNode head, int k) {
            return null;
        }

        public ListNode MiddleNode(ListNode head) {
            ListNode middleNode = head;
            while(head != null && head.next != null) {
                middleNode = middleNode.next;
                head = head.next.next;
            }
            return middleNode;
        }

        public ListNode DetectCycle1(ListNode head) {
            ListNode listNode = head;
            int imax = 1;
            while(head != null && head.next != null) {
                ListNode node = listNode;
                for(int i = 0; i < imax; i++) {
                    if(node == head.next) {
                        return node;
                    }
                    node = node.next;
                }
                head = head.next;
                imax++;
            }
            return null;
        }

        public ListNode DetectCycle(ListNode head) {
            if(head == null || head.next == null)
                return null;
            ListNode fast = head;
            ListNode slow = head;

            while(fast != null && slow != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
                if(fast == slow)
                    break;
            }

            if(fast != slow) {
                return null;
            }

            slow = head;

            while(fast != slow) {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }

        //удаляет n-й узел из конца списка
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            if(head == null || head.next == null)
                return null;

            ListNode back = head;
            ListNode front = head;

            for(int i = 0; i < n; i++)
                front = front.next;

            if(front == null)
                return head.next;

            while(front.next != null) {
                front = front.next;
                back = back.next;
            }

            back.next = back.next.next;
            return head;
        }

        public ListNode RotateRight(ListNode head, int k) {
            if(head == null || head.next == null)
                return head;
            ListNode fast = head;
            int i = 1;
            for(; fast.next != null; i++) {
                fast = fast.next;
            }
            fast.next = head;
            fast = fast.next;
            if(i <= k) {
                k = k % i;
            }
            for(int j = 0; j < i - k - 1; j++) {
                fast = fast.next;
            }

            ListNode res = fast.next;
            fast.next = null;
            return res;
        }

        public ListNode DeleteDuplicates(ListNode head) {
            if(head == null || head.next == null)
                return head;
            ListNode node = head;
            while(node.next != null) {
                if(node.val == node.next.val) {
                    node.next = node.next.next;
                } else
                    node = node.next;
            }
            return head;
        }

        public ListNode DeleteDuplicatesALL(ListNode head) {
            ListNode sentinel = new ListNode(0, head);
            ListNode pred = sentinel;

            while(head != null) {
                if(head.next != null && head.val == head.next.val) {
                    while(head.next != null && head.val == head.next.val) {
                        head = head.next;
                    }
                    pred.next = head.next;
                } else {
                    pred = pred.next;
                }

                // move forward
                head = head.next;
            }
            return sentinel.next;
        }

        public ListNode SortList(ListNode head) {
            ListNode node = head;
            while(node != null) {
                ListNode nodeSort = node.next;
                while(nodeSort != null) {
                    if(node.val > nodeSort.val)
                        (node.val, nodeSort.val) = (nodeSort.val, node.val);
                    nodeSort = nodeSort.next;
                }
                node = node.next;
            }
            return head;
        }
    }
}
