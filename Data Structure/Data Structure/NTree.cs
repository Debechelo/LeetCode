namespace DataStructure
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    public class NTree
    {

        public IList<int> Preorder(Node root)
        {
            List<int> list = new List<int>();
            if (root == null)
            {
                return null;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Peek() != null)
            {
                Node temp = q.Dequeue();

                list.Add(temp.val);

                foreach (var node in temp.children)
                {
                    if (node != null)
                        q.Enqueue(node);
                }
            }
            return list;
        }
    }
}
