namespace DataStructure.Test.ListTests
{
    [TestClass]
    public class DetectCycleTest
    {
        [TestMethod]
        public void DetectCycleNull()
        {
            ListNode listNode = null;
            List list = new List();
            ListNode beginNode = list.DetectCycle(listNode);

            Assert.IsNull(beginNode);
        }

        [TestMethod]
        public void DetectCycleOneLengthNoCycle()
        {
            ListNode listNode = new ListNode(3);
            List list = new List();
            ListNode beginNode = list.DetectCycle(listNode);

            Assert.IsNull(beginNode);

        }

        [TestMethod]
        public void DetectCycleOnelengthWithCycle()
        {
            ListNode listNode = new ListNode(3);
            listNode.next = listNode;
            List list = new List();
            ListNode beginNode = list.DetectCycle(listNode);

            Assert.AreEqual(listNode, beginNode);
        }

        [TestMethod]
        public void DetectCycleNLengthNoCycle()
        {
            ListNode listNode = new ListNode(3, new ListNode(4, new ListNode(5)));
            List list = new List();
            ListNode beginNode = list.DetectCycle(listNode);

            Assert.IsNull(beginNode);
        }

        [TestMethod]
        public void DetectCycleNlengthWithCycleToBegin()
        {
            ListNode listNode = new ListNode(3, new ListNode(4, new ListNode(5)));
            listNode.next.next.next = listNode;
            List list = new List();
            ListNode beginNode = list.DetectCycle(listNode);

            Assert.AreEqual(listNode, beginNode);

        }
        [TestMethod]
        public void DetectCycleNlengthWithCycleToMiddle()
        {
            ListNode listNode = new ListNode(3, new ListNode(4, new ListNode(5)));
            listNode.next.next.next = listNode.next;
            List list = new List();
            ListNode beginNode = list.DetectCycle(listNode);

            Assert.AreEqual(listNode.next, beginNode);
        }
    }
}
