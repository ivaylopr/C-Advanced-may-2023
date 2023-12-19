string text = string.Empty;
Stack<string> lastCommand = new ();
int numberOfOper = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfOper; i++)
{
	string[] commandArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries) ;
	int command = int.Parse(commandArg[0]);
	if (command==1)
	{
		lastCommand.Push(text);
		text += commandArg[1];

	}
	else if (command==2)
	{
		lastCommand.Push(text);
		int lenghtToEars = int.Parse(commandArg[1]);	
		text=text.Remove(text.Length - lenghtToEars);
	}
	else if (command==3)
	{
		int indx = int.Parse(commandArg [1])-1;
		Console.WriteLine(text[indx]);
	}
	else if (command==4)
	{
		text = lastCommand.Pop();
	}
}
