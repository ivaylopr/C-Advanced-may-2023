int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> number = new Queue<int>(numbers);
List<int> result = new List<int>();
while (number.Count>0)
{
    int currentN = number.Dequeue();
	if (currentN%2==0)
	{
		result.Add(currentN);
	}
}
Console.WriteLine(string.Join(", ",result));