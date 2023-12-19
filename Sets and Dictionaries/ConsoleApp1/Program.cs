Dictionary<string, Dictionary<string, List<string>>> continents = new();
int numberOfIn = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfIn; i++)
{
    string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
	string continent = input[0];	
	string country = input[1];
	string city = input[2];
	if (!continents.ContainsKey(continent))
	{
		continents.Add(continent,new Dictionary<string, List<string>>());
	}
	if (!continents[continent].ContainsKey(country)) 
	{
		continents[continent].Add(country,new List<string>());
	}
	continents[continent][country].Add(city);
}
foreach (var (continet,coutnries) in continents)
{
    Console.WriteLine($"{continet}:");
	foreach (var item in coutnries)
	{
        Console.WriteLine($"{item.Key} -> {string.Join(", ",item.Value)}");
    }
}