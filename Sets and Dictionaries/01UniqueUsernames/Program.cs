using System.Diagnostics.Metrics;
Queue<string> names = new();
int n = int.Parse(Console.ReadLine());

int counter = 0;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
	if (!names.Contains(input))
	{
		names.Enqueue(input);
	}
	else
	{
		continue;
	}
}
while (names.Count>0)
{
	string nameToPrint = names.Dequeue();
    Console.WriteLine(nameToPrint);
}