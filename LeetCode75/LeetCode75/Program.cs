using LeetCode75;

public class Program
{
    public static void Main(string[] args)
    {

        ListNode head = new ListNode(1, new ListNode(2));
        MergeTwoSortedLists mtsl = new MergeTwoSortedLists();
        ListNode reverseHead = mtsl.ReverseList(head);
        Console.WriteLine(1);
    }

}
