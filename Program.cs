TowerOfHanoi.Sort(4, 'a', 'b', 'c');


public class TowerOfHanoi
{
    public static void Sort(int num, char a = 'A', char b = 'B', char c ='C')
    {
        if (num == 1)
            Console.WriteLine($"moving {a} to {c}");
        
        else
        {
            Sort(num - 1, a, c, b);
            Console.WriteLine($"moving {a} to {c}");
            Sort(num - 1, b, a, c);
        }
    }
}