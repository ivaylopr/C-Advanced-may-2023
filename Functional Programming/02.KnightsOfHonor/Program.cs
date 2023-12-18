Action<string[]> printNames = (string[] input) =>
{
    foreach (var name in input)
    {
        {
            Console.WriteLine($"Sir {name}");
        }
    }
};
string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
printNames(input);