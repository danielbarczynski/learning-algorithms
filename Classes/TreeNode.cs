namespace Tree
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode RightNode { get; set; }
        public TreeNode LeftNode { get; set; }
        private int result = 0;
        public List<int> treeList = new List<int>();

        public TreeNode(int data)
        {
            Data = data;
        }

        public void Insert(int value)
        {
            if (value >= Data)
            {
                if (RightNode == null)
                    RightNode = new TreeNode(value);

                else
                    RightNode.Insert(value);
            }

            else
            {
                if (LeftNode == null)
                    LeftNode = new TreeNode(value);

                else
                    LeftNode.Insert(value);
            }
        }

        public void Traverse()
        {
            if (LeftNode != null)
                LeftNode.Traverse();

            Console.Write(Data + " ");

            if (RightNode != null)
                RightNode.Traverse();
        }
    }
}