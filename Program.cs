FibonacciIterative(9);
Console.WriteLine(FibonacciRecursive(4));

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
    // for n = 4: 
	// called once on n4 for n - 1 (3) 
	// called once on n3 for n - 1 (2) returns 1
	// called once on n3 for n - 2 (1) returns 1
	// backing - called once on n4 for n - 2 (2) returns 1. result = 3
	// for n =5: this will be called 3 times for n -1 and 2 times for n - 2. result = 5
    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}