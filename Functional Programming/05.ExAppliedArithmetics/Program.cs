using System.Diagnostics.Tracing;
using System.Globalization;

List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
string command= string.Empty;
Action<List<int>> print = num =>
{ 
    Console.WriteLine(string.Join(" ", num));
};
Func<string, List<int>, List<int>> operation = (commandArg, nums) =>
{
	List<int> result = new List<int>();

	foreach (var item in nums)
	{
		switch(commandArg)
		{
			case "add":
				result.Add(item+1);
				break;
			case "multiply":
				result.Add(item*2);
				break;
			case "subtract":
				result.Add(item - 1);
				break;

        }
	}
	 
	return result;
};
while ((command=Console.ReadLine().ToLower())!="end")
{
	if (command=="print")
	{
		print(numbers);
	}
	else 
	{ 
		numbers=operation(command,numbers); 
	}
}
