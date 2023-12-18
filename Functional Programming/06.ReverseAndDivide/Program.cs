List<int> numbers =Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int n =int.Parse(Console.ReadLine());
Func<List<int>, List<int>> reverse = (list) =>
{
    List<int> result = new List<int>();
    for (int i = list.Count - 1; i >= 0; i--)
    {
        result.Add(list[i]);
    }
    return result;
};
Func<List<int>,Predicate<int>, List<int>> removeDevided = (list, isDivide) =>
{
    List<int> result = new();
    foreach (var item in list)
    {
        if (!isDivide(item))
        {
            result.Add(item);
        }
    }

    return result;
};
Predicate<int> isDivisible = x => x % n == 0;
Action<List<int>> print = num =>
{
    Console.WriteLine(string.Join(" ", num));
};
numbers =reverse(numbers);
numbers = removeDevided(numbers, isDivisible);
print(numbers);