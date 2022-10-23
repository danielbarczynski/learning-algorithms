var cache = new Dictionary<int, int>();

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