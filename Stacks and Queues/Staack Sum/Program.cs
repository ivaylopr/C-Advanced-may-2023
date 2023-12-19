int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> result = new Stack<int>(numbers);
string command = Console.ReadLine().ToLower();
while (command!="end")
{
    string[] commArg = command.Split().ToArray();
	if (commArg[0]=="add")
	{
		result.Push(int.Parse(commArg[1]));
		result.Push(int.Parse(commArg[2]));
	}
	else if (commArg[0]=="remove")
	{
		int numToRem = int.Parse(commArg[1]);
		if (result.Count>numToRem)
		{
			for (int i = 0; i < numToRem; i++)
			{
				result.Pop();
			}
		}
		else
		{
            command = Console.ReadLine().ToLower();
            continue;
		}
	}
    command = Console.ReadLine().ToLower();
}
int sum = result.Sum();
Console.WriteLine($"Sum: {sum}");
