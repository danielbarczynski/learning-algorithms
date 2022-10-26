var tree = new Tree<int>(5);

tree.Insert(10);
tree.Insert(8);
tree.Insert(15);
tree.Insert(3);
tree.Insert(18);
tree.Insert(2);

tree.Traversal();

public class Tree<T>
{
    public int Data { get; set; }
    public Tree<int> Root { get; set; }
    public Tree<int> RightNode { get; set; }
    public Tree<int> LeftNode { get; set; }
    public List<int> Nodes { get; set; }

    public Tree(int data)
    {
        Data = data;
    }

    public void Insert(int data)
    {
        if (Root != null)
            Root.AddNode(data);
        else
            Root = new Tree<int>(data);
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