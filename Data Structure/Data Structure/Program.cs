using DataStructure;

public class Program
{
    public static void Main(string[] args) {
        ListNode listNode1 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5)))))));
        List list = new List();
        ListNode[] listNodes = { listNode1};
        ListNode head = list.DeleteDuplicatesALL(listNode1);
        Console.WriteLine(1);
    }

}
