using System.Reflection.Metadata.Ecma335;

int numOfOper = int.Parse(Console.ReadLine());
Stack<int> elements = new();

for (int i = 0; i < numOfOper; i++)
{
    string[] commArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int command = int.Parse(commArg[0]);
    if (command == 1)
    {
        elements.Push(int.Parse(commArg[1]));
    }
    else if (command == 2 && elements.Count>0)
    {
        elements.Pop();
    }
    else if (command==3 && elements.Count>0)
    {
        Console.WriteLine(elements.Max());
    }
    else if (command == 4 && elements.Count > 0)
    {
        Console.WriteLine(elements.Min());
    }
}
if (elements.Count>0)
{
    Console.WriteLine(String.Join(", ",elements));
}