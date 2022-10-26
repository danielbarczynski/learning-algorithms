using Tree;

var tree = new BinaryTree();

tree.Insert(10);
tree.Insert(3);
tree.Insert(2);
tree.Insert(4);
tree.Insert(18);
tree.Insert(7);
tree.Insert(22);
tree.Insert(20);

tree.Traverse(); 

Console.WriteLine();
Console.WriteLine(tree.Root.Sum(0));