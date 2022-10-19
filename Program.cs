// List<Knapsack> items = new List<Knapsack>()
// {
//     new Knapsack(3, 2), new Knapsack(1, 2), new Knapsack(3, 4), new Knapsack(4, 5), new Knapsack(2, 3)
// };

// int countLines = 0;
// int knapsackSize = 7;
// int itemsLength = items.Count();
// int[,] dynamicArray = new int[itemsLength, knapsackSize];

// Console.WriteLine("\nItems: ");

// foreach (var item in items)
// {
//     Console.WriteLine(item.Size + " | " + item.Value);
// }

// for (int i = 0; i <= itemsLength - 1; i++)
// {
//     for (int j = 0; j <= knapsackSize - 1; j++)
//     {
//         if (items[i].Size <= j && i > 1 && i - 1 > 0 && j != 0)
//         {
//             if (items[i].Size + items[i - 1].Size <= j)
//                 dynamicArray[i, j] = items[i].Value + dynamicArray[i - 1, j - i];
//             else if (items[i].Size <= j && j != 0)
//                 dynamicArray[i, j] = items[i].Value;
//         }

//         else
//         {
//             if (i - 1 > 0 && j != 0)
//                 dynamicArray[i, j] = items[i - 1].Value;
//             else
//                 dynamicArray[i, j] = 0;
//         }
//     }
// }

// foreach (var item in dynamicArray)
// {
//     if (countLines % 7 == 0)
//         Console.WriteLine();

//     countLines++;
//     Console.Write(item + " ");
// }

// public class Knapsack
// {
//     public int Size { get; set; }
//     public int Value { get; set; }
//     private Knapsack[] arr = new Knapsack[7];

//     public Knapsack this[int i]
//     {
//         get { return arr[i]; }
//         set { arr[i] = value; }
//     }

//     public Knapsack(int size, int value)
//     {
//         Size = size;
//         Value = value;
//     }
//}

int[] value = { 60, 60, 60, 60, 60, 100, 120 };
int[] weight = { 10, 10, 10, 10, 10, 20, 30 };
int capacity = 50;
int itemsCount = value.Length;

if (value.Length == weight.Length)
{
    int result = KnapSack(capacity, weight, value, itemsCount);
    Console.Write(result);
}

static int KnapSack(int capacity, int[] weight, int[] value, int itemsCount)
{
    int[,] K = new int[itemsCount + 1, capacity + 1];

    for (int i = 0; i <= itemsCount; ++i)
    {
        for (int w = 0; w <= capacity; ++w)
        {
            if (i == 0 || w == 0)
                K[i, w] = 0;
            else if (weight[i - 1] <= w)
                K[i, w] = Math.Max(value[i - 1] + K[i - 1, w - weight[i - 1]], K[i - 1, w]);
            else
                K[i, w] = K[i - 1, w];
        }
    }

    return K[itemsCount, capacity];
}


