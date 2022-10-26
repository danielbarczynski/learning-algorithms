using Tree;

// var tree = new BinaryTree();

// tree.Insert(10);
// tree.Insert(3);
// tree.Insert(2);
// tree.Insert(4);
// tree.Insert(18);
// tree.Insert(7);
// tree.Insert(22);
// tree.Insert(20);

// tree.Traverse(); 

// Console.WriteLine();

    SimpleTree AddNode(int key)
    {
        SimpleTree simpleTree = new SimpleTree();
        simpleTree.key = key;
        simpleTree.left = simpleTree.right = null;

        return (simpleTree);
    }

    static int Sum(SimpleTree root)
    {
        if (root == null)
            return 0;

        return (root.key + Sum(root.left) + Sum(root.right));
    }
    
    SimpleTree root = AddNode(1);
    root.left = AddNode(2);
    root.right = AddNode(3);
    root.left.left = AddNode(4);
    root.left.right = AddNode(5);
    root.right.left = AddNode(6);
    root.right.right = AddNode(7);
    root.right.left.right = AddNode(8);
 
    int sum = Sum(root);
    Console.WriteLine("Sum of all the elements is: " + sum);