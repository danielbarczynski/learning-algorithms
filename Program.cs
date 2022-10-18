Random random = new Random();
double knapsackSize = random.Next(100, 200);
int countItems = 0;
List<Knapsack> items = new List<Knapsack>();
List<Knapsack> knapsackItems = new List<Knapsack>();

for (int i = 0; i < 20; i++)
{
    items.Add(new Knapsack(random.Next(1, 30), random.Next(1, 30)));
}
Console.WriteLine("Knapsack size: " + knapsackSize);
Console.WriteLine("\nItems: ");
Console.WriteLine("\nS   V   P");

foreach (var item in items)
{
    Console.WriteLine(item.Size + " | " + item.Value + " | " + item.Profitability);
}

var sortedItems = items.OrderByDescending(x => x.Profitability);


foreach (var item in sortedItems)
{
    if (knapsackSize - item.Size >= 0)
    {
        countItems++;
        knapsackItems.Add(item);
        knapsackSize = knapsackSize - item.Size;
    }
}

Console.WriteLine("\nKnapsack items: ");
Console.WriteLine("\nS   V   P");

foreach (var item in knapsackItems)
{
    Console.WriteLine(item.Size + " | " + item.Value + " | " + item.Profitability);
}

Console.WriteLine("\nKnapsack size: " + knapsackSize);
Console.WriteLine("Number of knapsack items: " + countItems);

public class Knapsack
{
    public double Size { get; set; }
    public double Value { get; set; }
    public double Profitability { get; private set; }

    public Knapsack(double size, double value)
    {
        Size = size;
        Value = value;
        Profitability = Math.Round(value / size, 2);
    }
}