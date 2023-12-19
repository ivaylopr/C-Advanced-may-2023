int n = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();
string command = Console.ReadLine();
int carPassedCross = 0;
while (command!="end")
{
	if (command!="green")
	{
		cars.Enqueue(command);
		command = Console.ReadLine();
		continue;
	}
	int passed = n;
	while (cars.Count>0&&passed>0)
	{
		passed--;
		Console.WriteLine($"{cars.Dequeue()} passed!");
		carPassedCross++;
	}
    command = Console.ReadLine();
}
Console.WriteLine($"{carPassedCross} cars passed the crossroads.");