int result = 0;
int[] array = new int[1000];
var cache = new Dictionary<int, int>();
int countIterations = 0;
int countIterations2 = 0;

Console.WriteLine(Square(300));

foreach (var item in cache)
{
    Console.WriteLine("dictionary items: " + item.Key + " " + item.Value);
}

Console.WriteLine(Square(300));
Console.WriteLine(Square(300));
Console.WriteLine(Square(300));
Console.WriteLine(Square(300));
Console.WriteLine(Square(300));

Console.WriteLine(Fibonacci(40));
Console.WriteLine("iterations: " + countIterations); // 77
Console.WriteLine();
Console.WriteLine(Fibonacci2(40));
Console.WriteLine("iterations: " + countIterations2); // 204668309 !!!

int Square(int n)
{
    int result = 0;

    if (cache.ContainsKey(n))
    {
        Console.Write("cache ");
        return cache[n];
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result++;
        }
    }

    cache.Add(n, result);

    return result;
}

int Fibonacci(int n)
{
    countIterations++;

    if (n <= 2)
        result = 1;
    
    else if (array[n] != 0)
        result = array[n];
    else
        result = Fibonacci(n - 1) + Fibonacci(n - 2);
    
    array[n] = result;

    return result;
}

int Fibonacci2(int n)
{
    countIterations2++;

    if (n <=2 )
        return 1;
    
    return Fibonacci2(n - 1) + Fibonacci2(n - 2);
}
