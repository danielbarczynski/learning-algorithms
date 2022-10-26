public class SimpleTree
{
    public int key;
    public SimpleTree  left, right;

    public static SimpleTree AddNode(int key)
    {
        SimpleTree simpleTree = new SimpleTree();
        simpleTree.key = key;
        simpleTree.left = simpleTree.right = null;

        return (simpleTree);
    }

    public static int Sum(SimpleTree root)
    {
        if (root == null)
            return 0;

        return (root.key + Sum(root.left) + Sum(root.right));
    }
}