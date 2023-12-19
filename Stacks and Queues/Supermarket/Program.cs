Queue<string> people = new Queue<string> ();
string command = Console.ReadLine();

while (command!="End")
{
	if (command!="Paid")
	{
		people.Enqueue (command);
		command = Console.ReadLine ();
		continue;
	}
	while (people.Any())
	{
		Console.WriteLine(people.Dequeue());
	}
    command = Console.ReadLine();
}
Console.WriteLine($"{people.Count} people remaining.");