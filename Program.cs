using System.Collections;

TreeNode<int> root = new TreeNode<int>(14);
{
    TreeNode<int> node1 = root.AddChild(5);
    {
        TreeNode<int> node10 = node1.AddChild(4);
        
        TreeNode<int> node11 = node1.AddChild(9);
        {
            TreeNode<int> node100 = node11.AddChild(7);
            TreeNode<int> node101 = node11.AddChild(10);
        }
    }
    
    TreeNode<int> node2 = root.AddChild(16);
}

foreach (var node in root)
{
    Console.WriteLine(node.Data);
}


public class TreeNode<T> : IEnumerable<TreeNode<T>>
{
    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public ICollection<TreeNode<T>> Children { get; set; }

    public TreeNode(T data)
    {
        this.Data = data;
        this.Children = new LinkedList<TreeNode<T>>();
    }

    public TreeNode<T> AddChild(T child)
    {
        TreeNode<T> childNode = new TreeNode<T>(child) { Parent = this };
        this.Children.Add(childNode);
        return childNode;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<TreeNode<T>> GetEnumerator()
    {
        yield return this;
        foreach (var directChild in this.Children)
        {
            foreach (var anyChild in directChild)
            {
                Console.Write("  ");
                yield return anyChild;
            }
        }
    }
}