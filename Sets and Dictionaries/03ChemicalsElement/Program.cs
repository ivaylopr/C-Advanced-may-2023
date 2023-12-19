int n = int.Parse(Console.ReadLine());
HashSet<string> elements = new();
for (int i = 0; i < n; i++)
{
	string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
	foreach (var item in input)
	{
		elements.Add(item);
	}
}
Console.WriteLine(string.Join(" ",elements.OrderBy(x=>x)));