int[] values = { 2, 2, 4, 5, 3 };
int[] weights = { 3, 1, 3, 4, 2 };
int capacity = 7;
int itemsCount = values.Length;

if (values.Length == weights.Length)
{
    int result = Knapsack(capacity, weights, values, itemsCount);
	Console.WriteLine("\n");
    Console.WriteLine(result);
}

static int Knapsack(int capacity, int[] weights, int[] values, int itemsCount)
{
    int[,] knapsack = new int[itemsCount + 1, capacity + 1];

    for (int i = 0; i <= itemsCount; ++i)
    {
		Console.WriteLine();
		
        for (int j = 0; j <= capacity; ++j)
        {
            if (i == 0 || j == 0)
			{
                knapsack[i, j] = 0;
				Console.Write(knapsack[i, j] + " ");
			}

			else if (weights[i - 1] <= j)
			{
				// current values + diagonal arrow values or vertical arrow
				// for i = 2, j = 4 score = 4
				// [2 + [1, 4 - 1] = 2, 2]
				// Max(4, 2) = 4  
				// weights[i - 1] - cofamy sie o tyle, ile wynosi waga j =5, waga 3, ponieważ wtedy wartość się zgadzała
                knapsack[i, j] = Math.Max(values[i - 1] + knapsack[i - 1, j - weights[i - 1]], knapsack[i - 1, j]); 
				Console.Write(knapsack[i, j] + " ");
			}

			else
            {
				// values from vertical arrow
			    knapsack[i, j] = knapsack[i - 1, j]; 
				Console.Write(knapsack[i, j] + " ");
			}
		}
    }

    return knapsack[itemsCount, capacity];
}


