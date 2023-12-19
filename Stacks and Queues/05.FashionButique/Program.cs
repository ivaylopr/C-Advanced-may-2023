Stack<int> boxClotes = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int rackCapacity = int.Parse(Console.ReadLine());
int usedRack = 1;
int currentSum = 0;
while (boxClotes.Count>0)
{
    int currCl = boxClotes.Peek();
    currentSum += currCl;
    if (currentSum <= rackCapacity)
    {
        boxClotes.Pop();
    }
    else
    {
        currentSum = 0;
        usedRack++;
    }
}
Console.WriteLine(usedRack);