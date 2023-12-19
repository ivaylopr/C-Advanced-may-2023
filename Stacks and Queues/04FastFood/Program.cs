int foodQuantity = int.Parse(Console.ReadLine());
Queue<int> orders = new(Console.ReadLine()
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse));
Console.WriteLine(orders.Max());
while (orders.Count>0)
{
    if (orders.Peek()>foodQuantity)
    {
        break;
    }
    else
    {
        int orderToServe = orders.Dequeue();
        foodQuantity-=orderToServe;
    }
}
if (orders.Count==0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
}