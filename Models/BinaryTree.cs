namespace Tree
{
    public class BinaryTree
    {
        public TreeNode Root { get; set; }

        public void Insert(int value)
        {
            if (Root != null)
                Root.Insert(value);

            else
                Root = new TreeNode(value);
        }

        public void Traverse()
        {
            if (Root != null)
                Root.Traverse();
        }
        
        // public int Sum()
        // {
        //     if (Root != null)
        //         Root.Sum();
            
        //     return Root.Sum();
        // }
    }
}