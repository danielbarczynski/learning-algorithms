// int[] numbers = new int[] { 3, 9, 6, 5, 1, 8, 2, 4, 7 };

// foreach (var item in numbers)
// {
//     Console.Write(item + " ");
// }

// Console.WriteLine("\n");

// QuickSort quickSort = new QuickSort();
// var quickArray = quickSort.SortArray(numbers, 0, numbers.Length - 1);

// Console.WriteLine("\n");

// foreach (var item in quickArray)
// {
//     Console.Write(item + " ");
// }


// public class QuickSort
// {
//     public int[] SortArray(int[] array, int leftIndex, int rightIndex)
//     {
//         Console.Write("loop ");
//         int i = leftIndex;
//         int j = rightIndex;
//         int pivot = array[leftIndex];
//         Console.Write($"p{pivot} i{i} j{j} ");
//         while (i <= j)
//         {
//             while (array[i] < pivot)
//             {
//                 i++;
//                 Console.Write($"i{i} ");
//             }

//             while (array[j] > pivot)
//             {
//                 j--;
//                 Console.Write($"j{j} ");
//             }

//             if (i <= j)
//             {
//                 int temp = array[i];
//                 array[i] = array[j];
//                 array[j] = temp;
//                 i++;
//                 j--;
//                 Console.Write($"[i{i} ");
//                 Console.Write($"j{j}] ");
//                 Console.WriteLine("\n");
//                 foreach (var item in array)
//                 {
//                     Console.Write(item + " ");
//                 }
//                 Console.WriteLine("\n");
//             }
//         }

//         if (leftIndex < j)
//         {
//             SortArray(array, leftIndex, j);
//             Console.Write("left ");
//         }
//         if (i < rightIndex)
//         {
//             SortArray(array, i, rightIndex);
//             Console.Write("right ");
//         }
//         return array;
//     }
// }

int[] numbers = new int[10];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 100);
}

Console.WriteLine("before sorting: ");

foreach (var item in numbers)
{
    Console.Write(item + " ");
}

QuickSort.SortArray(numbers);

Console.WriteLine("\nafter sorting: ");

foreach (var item in numbers)
{
    Console.Write(item + " ");
}

public class QuickSort
{
    public static void SortArray(int[] array)
    {
        int lowIndex = 0;
        int highIndex = array.Length - 1;
        SortArray(array, lowIndex, highIndex);
    }
    public static void SortArray(int[] array, int lowIndex, int highIndex)
    {
        if (lowIndex >= highIndex)
            return;

        //Random random = new Random();
        // int pivotIndex = random.Next(lowIndex, highIndex);
        // int pivot = array[pivotIndex];
        int pivot = array[highIndex];
        int leftPointer = lowIndex;
        int rightPointer = highIndex;

        while (leftPointer < rightPointer)
        {
            while (array[leftPointer] <= pivot && leftPointer < rightPointer)
            {
                leftPointer++;
            }

            while (array[rightPointer] >= pivot && leftPointer < rightPointer)
            {
                rightPointer--;
            }
            
            Swap(array, leftPointer, rightPointer);
        }
        
        Swap(array, leftPointer, highIndex);
        SortArray(array, leftPointer + 1, highIndex);
        SortArray(array, lowIndex, leftPointer - 1);
    }

    public static void Swap(int[] array, int leftPointer, int rightPointer)
    {
        int temp = array[leftPointer];
        array[leftPointer] = array[rightPointer];
        array[rightPointer] = temp;
    }
}