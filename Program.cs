int[] array = new int[] { 3, 6, 2, 8, 5, 9, 4, 7, 1 };
var result = bubbleSort(array);
foreach (var num in result)
{
    Console.Write(num + " ");
}

int[] bubbleSort(int[] array)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.WriteLine($"sorted {j} j time");
        bool isSorted = true;
        for (int i = 0; i < array.Length - j; i++)
        {
            Console.WriteLine($"\tsorted {i} i time");
            int temp = 0;
            try
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    isSorted = false;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
            if (isSorted == true)
                break;
    }

    return array;
}