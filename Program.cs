using Tree;

var tree = new TreeNode(5);

tree.Insert(10);
tree.Insert(3);
tree.Insert(2);
tree.Insert(4);
tree.Insert(18);
tree.Insert(7);
tree.Insert(22);
tree.Insert(20);
tree.Traverse();

int sum = SumTree(tree);

Console.WriteLine("Sum of all elements in the tree: " + sum);

int SumTree(TreeNode root)
{
    if (root == null)
        return 0;

    return root.Data + SumTree(root.LeftNode) + SumTree(root.RightNode);
}
