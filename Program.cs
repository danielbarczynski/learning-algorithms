Random random = new Random();
int[] numbers = new int[random.Next(5, 30)];
int targetNumber = random.Next(1, 100);

for (int i = 0; i < numbers.Length - 1; i++)
{
    numbers[i] = random.Next(1, 100);
}

int[] sortedNumbers = numbers.OrderBy(x => x).ToArray();
BinarySearch(targetNumber, sortedNumbers);

static int BinarySearch(int targetNumber, int[] numbers)
{
    int middleNumber = (numbers[0] + numbers[numbers.Length - 1]) / 2;
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (middleNumber == targetNumber)
            return middleNumber;
        
        else if (middleNumber > targetNumber)
            BinarySearch(targetNumber, numbers);

    }

    return 5;
}