using System.Collections.Specialized;

List<double> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
Dictionary<double,int> count = new Dictionary<double,int>();

foreach (var item in list)
{
	if (!count.ContainsKey(item))
	{
		count.Add(item,0);
	}
	count[item]++;
}
foreach (var item in count)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}
