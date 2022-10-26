namespace Tree
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode RightNode { get; set; }
        public TreeNode LeftNode { get; set; }
        private int result = 0;
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

          public int Sum(int data)
        {
            if (LeftNode != null)
                LeftNode.Sum(Data);

            if (RightNode != null)
                RightNode.Sum(Data);
            
            return result;
        }
    }
}