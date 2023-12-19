string expression = Console.ReadLine();
Stack<char> opens = new();
Queue<char> closing = new();

foreach (var item in expression)
{
    if (item == '(' || item == '[' || item == '{')
    {
        opens.Push(item);
    }
    else if (item == ')' || item == ']' || item == '}')
    {
        closing.Enqueue(item);
    }
    
}
bool isBalanced = true;
while (opens.Count > 0 && closing.Count > 0)
{
    char currOpen = opens.Peek();
    char currClose = closing.Peek();
    if ((currOpen == '(' && currClose==')') || (currOpen=='['&& currClose==']') || (currOpen=='{'&& currClose=='}'))
    {
        opens.Pop();
        closing.Dequeue();
    }

    else
    {
        isBalanced = false;
        break;
    }
}
if (isBalanced&&opens.Count==0&&closing.Count==0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}