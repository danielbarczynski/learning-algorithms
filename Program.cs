List<Knapsack> items = new List<Knapsack>()
{
    new Knapsack(3, 2), new Knapsack(1, 2), new Knapsack(3, 4), new Knapsack(4, 5), new Knapsack(2, 3)
};

int knapsackSize = 7;
int itemsLength = items.Count();

Console.WriteLine("\nItems: ");

foreach (var item in items)
{
    Console.WriteLine(item.Size + " | " + item.Value);
}

for (int i = 0; i <= itemsLength - 1; i++)
{
    Console.WriteLine();
// create arr[i, j] for storing ?
    for (int j = 0; j <= knapsackSize - 1; j++)
    {
        
        if (items[i].Size <= i && i > 1 && i - 1 > 0 && j != 0)
        {
            if (items[i].Size + items[i - 1].Size <= j)
                Console.Write(items[i].Value + items[i - 1].Value);
        }

        else if (items[i].Size <= i && j != 0)
        {
            Console.Write(items[i].Value);
        }

        else
        {
            if (i - 1 > 0 && j != 0)
                Console.Write(items[i - 1].Value);
            else
                Console.Write(0);
        }
    }
}


public class Knapsack
{
    public double Size { get; set; }
    public double Value { get; set; }
    private Knapsack[] arr = new Knapsack[7];

    public Knapsack this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }

    public Knapsack(double size, double value)
    {
        Size = size;
        Value = value;
    }
}