string input = Console.ReadLine();
Dictionary<char, int> symbolsCnt = new();
for (int i = 0; i < input.Length; i++)
{
    char currentSymbol = input[i];
	if (!symbolsCnt.ContainsKey(currentSymbol))
	{
		symbolsCnt.Add(currentSymbol, 0);
	}
	symbolsCnt[currentSymbol]++;
}
foreach (var item in symbolsCnt.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}