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
