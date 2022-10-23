FibonacciIterative(9);
Console.WriteLine(FibonacciRecursive(9));

void FibonacciIterative(int n)
{
    int a = 0;
    int b = 1; 
    int c = 0;
    
    Console.Write(a + " " + b + " ");

    for (int i = 2; i <= n; i++)
    {
        c = a + b;

        Console.Write(c + " ");
        
        a = b;
        b = c;
    }
    Console.WriteLine();
}

int FibonacciRecursive(int n)
{
    if (n <= 2)
        return 1;
    
    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}