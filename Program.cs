Random random = new Random();

int[] numbers = new int[random.Next(10, 30)];
int leftIndex = 0;
int rightIndex = numbers.Length - 1;
int iterationCount = 0;

for (int i = 0; i < numbers.Length - 1; i++)
{
    numbers[i] = random.Next(1, 100);
}

int[] sortedNumbers = numbers.OrderBy(x => x).ToArray();

Console.WriteLine("Sorted numbers:");

foreach (var item in sortedNumbers)
{
    Console.Write(item + " ");
}

Console.Write("\nEnter target number: ");
int targetNumber = Convert.ToInt32(Console.ReadLine());

int result = BinarySearch(sortedNumbers, targetNumber, leftIndex, rightIndex);
Console.WriteLine("\n\nNumber of iterations: " + iterationCount);
Console.WriteLine("Result: " + result);

int BinarySearch(int[] numbers, int targetNumber, int leftIndex, int rightIndex)
{
    // prevent stack overflow (array length)
    int middleNumber = leftIndex + ((rightIndex - leftIndex) / 2);
    iterationCount++;

    // prevent infinite recursion
    if (leftIndex > rightIndex)
        return -1;

    if (numbers[middleNumber] == targetNumber)
        return middleNumber;

    else if (numbers[middleNumber] > targetNumber)
        BinarySearch(numbers, targetNumber, leftIndex, middleNumber - 1);

    return BinarySearch(numbers, targetNumber, middleNumber + 1, rightIndex);
}