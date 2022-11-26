namespace DataStructure
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class List
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
                return null;
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;
            ListNode sortedList = new ListNode();
            ListNode listNode = sortedList;

            bool flag1 = true;
            bool flag2 = true;

            while (flag1 || flag2)
            {
                if (flag1)
                {
                    if (list1.val <= list2.val || !flag2)
                    {
                        listNode.next = new ListNode(list1.val);
                        listNode = listNode.next;
                        if (list1.next == null)
                            flag1 = false;
                        else list1 = list1.next;
                    }
                }
                if (flag2)
                {
                    if (list2.val < list1.val || !flag1)
                    {
                        listNode.next = new ListNode(list2.val);
                        listNode = listNode.next;
                        if (list2.next == null)
                            flag2 = false;
                        else list2 = list2.next;
                    }
                }
            }
            return sortedList.next;
        }

        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode node = head.next;
            ListNode nextNode = node.next;
            head.next = null;
            while (node != null)
            {
                nextNode = node.next;
                node.next = head;
                head = node;
                node = nextNode;
            }
            return head;
        }

        public ListNode MiddleNode(ListNode head)
        {
            ListNode middleNode = head;
            while (head != null && head.next != null)
            {
                middleNode = middleNode.next;
                head = head.next.next;
            }
            return middleNode;
        }

        public ListNode DetectCycle(ListNode head)
        {
            ListNode listNode = head;
            int imax = 1;
            while (head != null && head.next != null)
            {
                ListNode node = listNode;
                for (int i = 0; i < imax; i++)
                {
                    if (node == head.next)
                    {
                        return node;
                    }
                    node = node.next;
                }
                head = head.next;
                imax++;
            }
            return null;
        }
    }
}
