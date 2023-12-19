int[] elementsOper = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Queue<int> queueEl = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
int elementToPop = elementsOper[1];
int surchedElement = elementsOper[2];

for (int i = 0; i < elementToPop; i++)
{
    queueEl.Dequeue();
}

if (queueEl.Contains(surchedElement))
{
    Console.WriteLine("true");
}
else if (queueEl.Count > 0)
{
    Console.WriteLine(queueEl.Min());
}
else
{
    Console.WriteLine(0);
}