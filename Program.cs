int[] numbers = new int[] { 3, 9, 6, 5, 1, 8, 2, 4 };
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
        int i = leftIndex;
        int j = rightIndex;
        int pivot = array[leftIndex];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            SortArray(array, leftIndex, j);

        if (i < rightIndex)
            SortArray(array, i, rightIndex);

        return array;
    }
}