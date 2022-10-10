Random random = new Random();
DataStructures ds = new DataStructures();

for (int i = 0; i <= 5; i++)
    ds.numbers.Add(random.Next(0, 10));

foreach (var item in ds.numbers)
    Console.WriteLine(item);

string daniel = ds.people.Find(x => x == "Daniel Barczyński");
Console.WriteLine(daniel + "\n");

ds.people.Remove("Alicja Musiałkiewicz");

foreach (var item in ds.people)
{
    Console.WriteLine(item);
}

Console.WriteLine("--------");

ds.peopleArray = ds.peopleArray.Concat(new string[] { "Kuba Taźbirek"}).ToArray();
ds.peopleArray[1] = "yo";
ds.peopleArray = ds.peopleArray.Append("najs").ToArray();

foreach (var item in ds.peopleArray)
{
    Console.WriteLine(item);
}

//-------------------------------------------------------------------------------------

BubbleSort bs = new BubbleSort();

Console.WriteLine("before sorting:\n");

for (int i = 0; i < bs.numbers2.Length; i++)
{
    Console.Write(bs.numbers2[i] + " ");
}

for (int i = 0; i < bs.numbers2.Length; i++)
{
    for (int j = 0; j < bs.numbers2.Length; j++)
    {      
        if (i + 1 >= bs.numbers2.Length || j + 1 >= bs.numbers2.Length)
            break;
            
        else if (bs.numbers2[j] > bs.numbers2[j + 1])
        {
            int storage = bs.numbers2[j + 1];
            bs.numbers2[j + 1] = bs.numbers2[j];  
            bs.numbers2[j] = storage;
        }
    }
}

Console.WriteLine();
Console.WriteLine("\nafter sorting:\n");

for (int i = 0; i < bs.numbers2.Length; i++)
{
    Console.Write(bs.numbers2[i] + " ");
}