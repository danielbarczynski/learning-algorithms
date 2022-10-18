Random random = new Random();
int knapsackSize = random.Next(100, 200);
List<Knapsack> knapsackItems = new List<Knapsack>();

for (int i = 0; i < 20; i++)
{
    knapsackItems.Add(new Knapsack(random.Next(1, 30), random.Next(1, 30)));
}

Console.WriteLine("S   V   P");

foreach (var item in knapsackItems)
{
    Console.WriteLine(item.Size + " | " + item.Value + " | " + item.Profitability);
}

public class Knapsack
{
    public double Size { get; set; }
    public double Value { get; set; }
    public double Profitability { get; private set; }

    public Knapsack(double size, double value)
    {
        Size = size;
        Value = value;
        Profitability = Math.Round(value/size, 2);
    }
}