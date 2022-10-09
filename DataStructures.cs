List<int> numbers = new List<int>();
List<string> people = new List<string>()
{
    "Daniel Barczyński", "Olek Kopijka", "Alicja Musiałkiewicz", "Gabriela Kuźmik", "Wiktoria Wesołowska"
};

string[] peopleArray = 
{ 
    "Daniel Barczyński", "Olek Kopijka", "Alicja Musiałkiewicz", "Gabriela Kuźmik", "Wiktoria Wesołowska" 
};

Random random = new Random();


for (int i = 0; i <= 5; i++)
    numbers.Add(random.Next(0, 10));

foreach (var item in numbers)
    Console.WriteLine(item);

string daniel = people.Find(x => x == "Daniel Barczyński");
Console.WriteLine(daniel + "\n");

people.Remove("Alicja Musiałkiewicz");

foreach (var item in people)
{
    Console.WriteLine(item);
}

Console.WriteLine("--------");

peopleArray = peopleArray.Concat(new string[] { "Kuba Taźbirek"}).ToArray();
peopleArray[1] = "yo";
peopleArray = peopleArray.Append("najs").ToArray();

foreach (var item in peopleArray)
{
    Console.WriteLine(item);
}