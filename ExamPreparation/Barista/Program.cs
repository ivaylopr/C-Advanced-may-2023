Queue<int> coffeQuantity = new(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
Stack<int> milkQuantity = new (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()); 
Dictionary<string,int> drinks=new Dictionary<string, int>()
{
    {"Cortado",0 },
    {"Espresso",0 },
    {"Capuccino",0 },
    {"Americano",0 },
    {"Latte",0 }

};
int sum = 0;
while (coffeQuantity.Count>0 && milkQuantity.Count>0)
{
    int currentCoffe= coffeQuantity.Dequeue();
    int currentMilk = milkQuantity.Pop();
    sum = currentCoffe + currentMilk;
    if (sum==50)
    {
        drinks["Cortado"]++;
    }
    else if (sum==75)
    {
        
        drinks["Espresso"]++;

    }
    else if (sum == 100)
    {
        
        drinks["Capuccino"]++;

    }
    else if (sum == 150)
    {
         drinks["Americano"]++;

    }
    else if (sum == 200)
    {
        drinks["Latte"]++;
    }
    else
    {
        currentMilk -= 5;
        milkQuantity.Push(currentMilk);
    }

}
if (coffeQuantity.Count==0 && milkQuantity.Count==0)
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
    Console.WriteLine("Coffee left: none");
    Console.WriteLine("Milk left: none");
}

else
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
    if (coffeQuantity.Count>0)
    {
        Console.Write("Coffee left: ");
        foreach (var item in coffeQuantity)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Coffee left: none");
    }
    if (milkQuantity.Count > 0)
    {
        Console.Write("Coffee left: ");
        foreach (var item in milkQuantity)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Milk left: none");
    }
    
}
foreach (var drink in drinks.OrderBy(d => d.Value).ThenByDescending(d => d.Key))
{
    if (drink.Value>0)
    {
        Console.WriteLine($"{drink.Key}: {drink.Value}");
    }
}
