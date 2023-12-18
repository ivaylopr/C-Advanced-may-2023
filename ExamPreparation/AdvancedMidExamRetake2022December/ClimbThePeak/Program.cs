using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

Dictionary<string, int> peeksInfo = new Dictionary<string, int>()
{
    { "Vihren",80 },
    { "Kutelo",90 },
    { "Banski Suhodol",100 },
    { "Polezhan",60 },
    { "Kamenitza",70 }

};
Queue<string> peeksNames=new(new List<string>() { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" });
List<string> conqueredNames = new();
Stack<int> foodPortions = new(Console.ReadLine()
                                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse));
Queue<int> staminaQuantity = new(Console.ReadLine()
                                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse));
while (foodPortions.Any() && staminaQuantity.Any() && peeksNames.Any())
{
    int foodPortion = foodPortions.Pop();
    int dayliStamina = staminaQuantity.Dequeue();
    int peekDificultly = peeksInfo[peeksNames.Peek()];
    if (foodPortion+dayliStamina>=peekDificultly)
    {
        conqueredNames.Add(peeksNames.Dequeue());
    }
}
if (peeksNames.Any())
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
else
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
if (conqueredNames.Count>0)
{
    Console.WriteLine("Conquered peaks:");
    foreach (var item in conqueredNames)
    {
        Console.WriteLine(item);
    }
}

