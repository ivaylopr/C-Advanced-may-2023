using System.ComponentModel.Design;

int[] range = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string command = Console.ReadLine();    

Func<int, int, List<int>> nums = (start,end) =>
{
    List<int> result = new List<int>();
	for (int i = start; i <= end; i++)
	{
		result.Add(i);
	}
	return result;
};


Func<string, int, bool> isFoundMatch = (condition, number) =>
{
	if (condition == "even")
	{
		return number % 2 == 0;
	}
	else
	{
		return number % 2 != 0;
	}
};
List<int> list = nums(range[0], range[1]);
List<int> result = new();
foreach (var item in list)
{
	if (isFoundMatch(command, item))
	{
		result.Add(item);
    }
	
}
Console.WriteLine(string.Join(" ",result));
