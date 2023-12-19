string[] names = Console.ReadLine().Split();
Queue<string> people = new Queue<string>(names);
int n = int.Parse(Console.ReadLine());

while (people.Count>1)
{
	for (int i = 0; i < n-1; i++)
	{
		people.Enqueue(people.Dequeue());

	}
	Console.WriteLine($"Removed {people.Dequeue()}");
}
Console.WriteLine($"Last is {people.Peek()}");