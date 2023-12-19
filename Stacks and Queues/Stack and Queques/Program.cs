//1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
//(2 + 3)
//(3 + 1)
//(2 - (2 + 3) * 4 / (3 + 1))
string input = Console.ReadLine();
Stack<int> indx = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
	char currentEl = input[i];
	if (input[i]=='(')
	{
		indx.Push(i);
	}
	else if (input[i]==')')
	{
		int openIndx = indx.Pop();
		for (int j = openIndx; j <= i; j++)
		{
			Console.Write(input[j]);
		}
		Console.WriteLine();
	}
}
