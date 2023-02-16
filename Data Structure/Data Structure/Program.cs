using DataStructure;

using Data_Structure;
using System;

public class Program {
    public static void Main(string[] args) {
        //ListNode listNode1 = new ListNode(1, new ListNode(5, new ListNode(2, new ListNode(3, new ListNode(8, new ListNode(4, new ListNode(5)))))));
        //List list = new List();
        //ListNode[] listNodes = { listNode1};
        //ListNode head = list.SortList(listNode1);
        //Console.WriteLine(1);

        var list1 = ActionsWithArray.AddToArrayForm(new int[] { 2, 7, 4 }, 181);
        var list2 = ActionsWithArray.AddToArrayForm(new int[] { 0, 0, 7, 4 }, 81);
        var list3 = ActionsWithArray.AddToArrayForm(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 1);

        for(int i = 0; i < list3.Count; i++) {
            Console.Write(list3[i]);
        }
    }

}
