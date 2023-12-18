int endRange = int.Parse(Console.ReadLine());
List<Predicate<int>> division = new();
HashSet<int> dividers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();
int[] numbers = Enumerable.Range(1,endRange).ToArray(); 

foreach (int divider in dividers)
{
    
    division.Add(n => n % divider == 0);
}

foreach (int num in numbers)
{
    bool isDivided = true;
    foreach (var match in division)
    {
        if (!match(num))
        {
            isDivided = false;
            break;
        }
    }
    if (isDivided)
    {
        Console.Write($"{num} ");
    }
}