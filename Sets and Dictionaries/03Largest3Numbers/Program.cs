List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int[] maxEl =new int[3];
if (numbers.Count < 3)
{
    Console.WriteLine($"{string.Join(" ",numbers)}");
}
else
{
	numbers = numbers.OrderByDescending(x => x).ToList();
	for (int i = 0; i < 3; i++)
	{
        Console.Write(numbers[i]+" ");
    }
}
