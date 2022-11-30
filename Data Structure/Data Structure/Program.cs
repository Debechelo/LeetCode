using DataStructure;

public class Program
{
    public static void Main(string[] args)
    {
        ListNode listNode = new ListNode(3, new ListNode(4));
        int n = 2;
        List list = new List();
        ListNode head = list.RemoveNthFromEnd(listNode, n);
        Console.WriteLine(1);
    }

}
