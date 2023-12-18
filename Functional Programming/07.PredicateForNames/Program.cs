int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Predicate<string> match = name=>name.Length<=n;
Action<string[], Predicate<string>> printNames = (names, match) =>
{
    foreach (string name in names)
    {
        if (match(name))
        {
            Console.WriteLine(name);
        }
    }
};
printNames(names, match);