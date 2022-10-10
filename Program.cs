int[] numbers2 = new int[] { 2, 5, 4, 6, 7, 1 , 8, 9};
bool isSorted = false;

Console.WriteLine("before sorting:\n");

for (int i = 0; i < numbers2.Length; i++)
{
    Console.Write(numbers2[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < numbers2.Length; i++)
{
    Console.WriteLine($"sorted {i} i time");
    isSorted = false;

    for (int j = 0; j < numbers2.Length - i; j++)
    {             

        if (i + 1 >= numbers2.Length || j + 1 >= numbers2.Length - i)
            break;
            
        else if (numbers2[j] > numbers2[j + 1])
        {
            int storage = numbers2[j + 1];
            numbers2[j + 1] = numbers2[j];  
            numbers2[j] = storage;
            isSorted = true;
        }
        Console.WriteLine($"\tsorted {j} j time");
    }

    if (isSorted == false)
        break;
}

Console.WriteLine();
Console.WriteLine("\nafter sorting:\n");

for (int i = 0; i < numbers2.Length; i++)
{
    Console.Write(numbers2[i] + " ");
}
