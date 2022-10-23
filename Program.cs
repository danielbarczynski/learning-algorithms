Console.Write(Fibonacci(4));
Console.Write(FibonacciRecursive(4));

int Fibonacci(int n)
{
    if (n <= 2)
        return 1;
    
    int result = 0;

    for (int i = 0; i < n; i++)
    {
        result = i + (i - 1);
    }

    return result;
}

int FibonacciRecursive(int n)
{
    return n;
}