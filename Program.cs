Random random = new Random();

int[] numbers = new int[random.Next(10, 30)];
int leftIndex = 0;
int iterationCount = 0;

for (int i = 0; i < numbers.Length - 1; i++)
{
    numbers[i] = random.Next(1, 100);
}

int[] sortedNumbers = numbers.OrderBy(x => x).ToArray();
int rightIndex = sortedNumbers.Length - 1;

Console.WriteLine("Sorted numbers:");

foreach (var item in sortedNumbers)
{
    Console.Write(item + " ");
}

Console.Write("\nEnter target number: ");
int targetNumber = Convert.ToInt32(Console.ReadLine());

int result = BinarySearch(sortedNumbers, targetNumber, leftIndex, rightIndex);
Console.WriteLine("\n\nNumber of iterations: " + iterationCount);
Console.WriteLine("Target number found at index: " + result);
Console.WriteLine("Result: " + sortedNumbers[result]);

int BinarySearch(int[] numbers, int targetNumber, int leftIndex, int rightIndex)
{
    if (leftIndex <= rightIndex)
    {
        int middleNumber = rightIndex;
        iterationCount++;

        if (numbers[middleNumber] == targetNumber)
            return middleNumber;

        else if (numbers[middleNumber] > targetNumber)
            return BinarySearch(numbers, targetNumber, leftIndex, --middleNumber);

        return BinarySearch(numbers, targetNumber, ++middleNumber, rightIndex);
    }

    return -1;
}