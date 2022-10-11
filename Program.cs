int[] numbers = new int[] { 3, 9, 6, 5, 1, 8, 2, 4 };
int[] lowerNums = new int [] {};
int[] higherNums = new int [] {};
int[] sortedNums = new int [] {};
int length = numbers.Length;

Console.WriteLine("before sorting");

for (int i = 0; i < length; i++)
{
    Console.Write(numbers[i]);
}

Console.WriteLine("\nafter sorting:");

for (int i = 0; i < length; i++)
{
    if (numbers[i] < numbers[length - 1]) 
        lowerNums = lowerNums.Append(numbers[i]).ToArray();
    
    else if (numbers[i] > numbers[length - 1])
        higherNums = higherNums.Append(numbers[i]).ToArray();
        
    else 
        sortedNums = sortedNums.Append(numbers[i]).ToArray();
}

for (int i = 0; i < lowerNums.Length; i++)
{
    Console.Write(lowerNums[i]);
}

Console.WriteLine();

for (int i = 0; i < higherNums.Length; i++)
{
    Console.Write(higherNums[i]);
}

Console.WriteLine();

for (int i = 0; i < sortedNums.Length; i++)
{
    Console.Write(sortedNums[i]);
}
