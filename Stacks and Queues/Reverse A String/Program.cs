string input = Console.ReadLine();
Stack<char> ts = new Stack <char>(input);

while (ts.Count>0)
{
    char result = ts.Pop();
    Console.Write(result);
}
