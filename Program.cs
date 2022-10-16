int[] arr = new int[]{ 4, 3, 2, 1};
Stack<int> stackA = new Stack<int>(arr);
Stack<int> stackB = new Stack<int>();
Stack<int> stackC = new Stack<int>();

TowerOfHanoi.Sort(4, 'a', 'b', 'c');
TowerOfHanoi.SortStacks(4, stackA, stackB, stackC);

foreach (var item in stackC)
{
    Console.WriteLine(item);
}

/* 
3 steps:
n - 1 from A to B
1 from A to C
n - 1 from B to C
*/

public class TowerOfHanoi
{
    public static void Sort(int num, char a = 'A', char b = 'B', char c ='C')
    {
        if (num == 1)
            // 1 from A to C
            Console.WriteLine($"moving {a} to {c}");
        
        else
        {
            // n - 1 from A to B
            Sort(num - 1, a, c, b);
            Console.WriteLine($"moving {a} to {c}");
            
            // n - 1 from B to C
            Sort(num - 1, b, a, c);
        }
    }

    public static void SortStacks(int num, Stack<int> a, Stack<int> b, Stack<int> c)
    {
        if (num == 1)
            // 1 from A to C
            c.Push(a.Pop());
        
        else
        {
            // n - 1 from A to B
            SortStacks(num - 1, a, c, b);
            c.Push(a.Pop());

            // n - 1 from B to C
            SortStacks(num - 1, b, a, c);
        }
    }
}