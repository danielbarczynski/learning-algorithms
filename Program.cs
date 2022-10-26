// using System.Collections;

// TreeNode<int> root = new TreeNode<int>(14);
// {
//     TreeNode<int> node1 = root.AddChild(5);
//     {
//         TreeNode<int> node10 = node1.AddChild(4);
        
//         TreeNode<int> node11 = node1.AddChild(9);
//         {
//             TreeNode<int> node100 = node11.AddChild(7);
//             TreeNode<int> node101 = node11.AddChild(10);
//         }
//     }
    
//     TreeNode<int> node2 = root.AddChild(16);
// }

// foreach (var node in root)
// {
//     Console.WriteLine(node.Data);
// }

// Console.WriteLine();
// Console.WriteLine("Sum: " + root.Sum(root));


// public class TreeNode<T> : IEnumerable<TreeNode<T>>
// {
//     public T Data { get; set; }
//     public TreeNode<T> Parent { get; set; }
//     public ICollection<TreeNode<T>> Children { get; set; }

//     public TreeNode(T data)
//     {
//         Data = data;
//         Children = new LinkedList<TreeNode<T>>();
//     }

//     public TreeNode<T> AddChild(T child)
//     {
//         TreeNode<T> childNode = new TreeNode<T>(child) { Parent = this };
//         Children.Add(childNode);
        
//         return childNode;
//     }

//     public int Sum(TreeNode<int> root)
//     {  
//         if (root == null)
//             return 0;
            
//         return root.Data;
//     }

//     IEnumerator IEnumerable.GetEnumerator()
//     {
//         return GetEnumerator();
//     }

//     public IEnumerator<TreeNode<T>> GetEnumerator()
//     {
//         yield return this;

//         foreach (var directChild in this.Children)
//         {
//             foreach (var anyChild in directChild)
//             {
//                 Console.Write("  ");

//                 yield return anyChild;
//             }
//         }
//     }
// }

var tree = new Tree<int>(5);

tree.AddNode(10);
tree.AddNode(8);
tree.AddNode(15);
tree.AddNode(3);
tree.AddNode(18);
tree.AddNode(2);

tree.Traversal();

public class Tree<T>
{
    public int Data { get; set; }
    public Tree<int> RightNode { get; set; }
    public Tree<int> LeftNode { get; set; }
    public List<int> Nodes { get; set; }

    public Tree(int data)
    {
        Data = data;
    }

    public void AddNode(int value)
    {
        if (value >= Data)
        {
            if (RightNode == null)
                RightNode = new Tree<int>(value);
            else
                RightNode.AddNode(value);
        }
        
        else
        {
            if (LeftNode == null)
                LeftNode = new Tree<int>(value);
            else
                LeftNode.AddNode(value);
        } 
    }

    public void Traversal()
    {
        if (LeftNode != null)
            LeftNode.Traversal();
        
        Console.Write(Data + " ");

        if (RightNode != null)
            RightNode.Traversal();
    }
}