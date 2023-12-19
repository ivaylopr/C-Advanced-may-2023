int[] elementsOper = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Stack<int> stack = new(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
int elementToPop = elementsOper[1];
int surchedElement = elementsOper[2];

for (int i = 0; i < elementToPop; i++)
{
    stack.Pop();
}

if (stack.Contains(surchedElement))
{
    Console.WriteLine("true");
}
else if (stack.Count>0)
{
    Console.WriteLine(stack.Min());
}
else
{
    Console.WriteLine(0);
}