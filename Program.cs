int[] numbers = new int[] { 3, 9, 6, 5, 1, 8, 2, 4, 7 };

foreach (var item in numbers)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n");

QuickSort quickSort = new QuickSort();
var quickArray = quickSort.SortArray(numbers, 0, numbers.Length - 1);

foreach (var item in quickArray)
{
    Console.Write(item + " ");
}


public class QuickSort
{
    public int[] SortArray(int[] array, int leftIndex, int rightIndex)
    {
        Console.Write("loop ");
        int i = leftIndex;
        int j = rightIndex;
        int pivot = array[leftIndex];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                Console.Write("i++ ");
                i++;
            }

            while (array[j] > pivot)
            {
                Console.Write("j-- ");
                j--;
            }

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
                Console.Write("i++ ");
                Console.Write("j-- ");
                Console.WriteLine("\n");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n");
            }
        }

        if (leftIndex < j)
        {
            SortArray(array, leftIndex, j);
            Console.Write("left ");
        }
        if (i < rightIndex)
        {
            SortArray(array, i, rightIndex);
            Console.Write("right ");
        }
        return array;
    }
}