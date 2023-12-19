Queue<string> songList = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (songList.Count>0)
{
    string[] commandArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = commandArg[0];
    if (command=="Play")
	{
		songList.Dequeue();
	}
	else if (command == "Add")
	{
		string songToAdd = string.Join(" ",commandArg[1..]);
		if (!songList.Contains(songToAdd))
		{
			songList.Enqueue(songToAdd);
		}
		else
		{
			Console.WriteLine($"{songToAdd} is already contained!");
        }
	}
	else if (command == "Show")
	{
		Console.WriteLine(string.Join(", ",songList));
	}
}
Console.WriteLine("No more songs!");