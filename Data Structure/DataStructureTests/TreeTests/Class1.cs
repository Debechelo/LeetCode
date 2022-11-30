using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Test.TreeTests
{
    [TestClass]
    internal class Class1
    {

        [TestMethod]
        public void PreorderTest()
        {
            Node node = new Node(1, new List<Node> { });
            ListNode listNode = new ListNode(3, new ListNode(4, new ListNode(5)));
            listNode.next.next.next = listNode.next;
            List list = new List();
            ListNode beginNode = list.DetectCycle(listNode);

            Assert.AreEqual(listNode.next, beginNode);
        }
    }
}
