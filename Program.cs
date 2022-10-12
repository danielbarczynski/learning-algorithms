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

int[] numbers2 = new int[10];
Random random = new Random();
QuickSort2 quickSort2 = new QuickSort2();

for (int i = 0; i < numbers2.Length; i++)
{
    numbers2[i] = random.Next(1, 100); 
}

Console.WriteLine("before sorting: ");

foreach (var item in numbers2)
{
    Console.Write(item + " ");
}

quickSort2.SortArray(numbers2);

Console.WriteLine("\nafter sorting: ");

foreach (var item in numbers2)
{
    Console.Write(item + " ");
}

public class QuickSort2
{
    public int[] SortArray(int[] array)
    {
        int lowIndex = 0;
        int highIndex = array.Length - 1;
        return SortArray(array, lowIndex, highIndex);
    } 
    public int[] SortArray(int[] array, int lowIndex, int highIndex)
    {
        int pivot = highIndex;
        int leftPointer = lowIndex;
        int rightPointer = highIndex;
        
        while (array[leftPointer] < pivot && leftPointer < rightPointer)
        {
            leftPointer++;
        }

        while (array[rightPointer] > pivot && leftPointer < rightPointer)
        {
            rightPointer--;
        }

        Swap(array, leftPointer, rightPointer);

        return array;
    }

    public static void Swap(int[] array, int leftPointer, int rightPointer)
    {
        int temp = array[leftPointer];
        array[leftPointer] = array[rightPointer];
        array[rightPointer] = temp;
    }
}