int[] textilesValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
int[] medicamentsValues = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Queue<int> textiles= new Queue<int>(textilesValues);
Stack<int> medicaments = new Stack<int>(medicamentsValues);
Dictionary<string, int> healingItems = new Dictionary<string, int>()
{
    {"Patch",0 },
    {"Bandage",0 },
    {"MedKit",0 }
};
while (textiles.Count>0 && medicaments.Count>0)
{
    int currentTextile=textiles.Dequeue();
    int currentMedicament = medicaments.Pop();
    int sum = currentMedicament + currentTextile;
    if (sum==30)
    {
        //Patch
        healingItems["Patch"]+=1;
    }
    else if (sum==40)
    {
        //Bandage
        healingItems["Bandage"]++;
    }
    else if(sum>=100)
    {
        //MedKit
        healingItems["MedKit"]++;
        sum -= 100;
        if (medicaments.Count>0)
        {
            int nextEl = medicaments.Pop() + sum;
            medicaments.Push(nextEl);
        }
        
    }
    else
    {
        currentMedicament += 10;
        medicaments.Push(currentMedicament);
    }

}

    if (medicaments.Count==0 && textiles.Count>0)
    {
        Console.WriteLine("Medicaments are empty.");
    }
    else if (textiles.Count==0 && medicaments.Count>0)
    {
        Console.WriteLine("Textiles are empty.");
    }
    else if (textiles.Count==0 && medicaments.Count==0)
    {
        Console.WriteLine("Textiles and medicaments are both empty.");
    }
foreach (var item in healingItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    if (item.Value>0)
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}
if (medicaments.Count>0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ",medicaments)}");
}
else if (textiles.Count>0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ",textiles)}");
}
    