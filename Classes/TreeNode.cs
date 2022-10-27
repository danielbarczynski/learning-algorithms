public class TreeNode
{
    public int Data { get; private set; }
    public TreeNode RightNode { get; private set; }
    public TreeNode LeftNode { get; private set; }

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

    public static int Sum(TreeNode root)
    {
        if (root == null)
            return 0;

        return root.Data + Sum(root.LeftNode) + Sum(root.RightNode);
    }
}