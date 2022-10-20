Random random = new Random();
int[] numbers = new int[random.Next(5, 30)];
int targetNumber = random.Next(1, 100);
int leftIndex = 0;
int rightIndex = numbers.Length - 1;
for (int i = 0; i < numbers.Length - 1; i++)
{
    numbers[i] = random.Next(1, 100);
}

int[] sortedNumbers = numbers.OrderBy(x => x).ToArray();
BinarySearch(sortedNumbers, targetNumber, leftIndex, rightIndex);

static int BinarySearch(int[] numbers, int targetNumber, int leftIndex, int rightIndex)
{
    int middleNumber = (numbers[0] + numbers[numbers.Length - 1]) / 2;
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (middleNumber == targetNumber)
            return middleNumber;
        
        else if (middleNumber > targetNumber)
            BinarySearch(numbers, targetNumber, 0, middleNumber--);
        
        else
            BinarySearch(numbers, targetNumber, middleNumber++, rightIndex);

    }

    return 5;
}