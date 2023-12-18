Action<string[]> input = (string[] input) => Console.WriteLine(string.Join(Environment.NewLine,input));
string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
input(strings);