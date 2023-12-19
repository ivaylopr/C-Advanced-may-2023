Dictionary<string, Dictionary<string, int>> wardobe = new();
int numberOfIn= int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfIn; i++)
{
    string[] commArg = Console.ReadLine().Split(new string[] { "->", ","," " }, StringSplitOptions.RemoveEmptyEntries);
    string color = commArg[0];
    if (!wardobe.ContainsKey(color))
    {
        wardobe.Add(color, new Dictionary<string, int>());
    }

    for (int j = 1; j < commArg.Length; j++)
    {
        string kind = commArg[j];
        if (!wardobe[color].ContainsKey(kind))
        {
            wardobe[color].Add(kind, 0);
        }
        wardobe[color][kind]++;
    }
       
}
string[] surchedClo= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
string surchedCol = surchedClo[0];
string surchedDres = surchedClo[1];
foreach (var colorsClot in wardobe)
{
    Console.WriteLine($"{colorsClot.Key} clothes:");
    foreach (var clotCnt in colorsClot.Value)
    {
        string isFount = "(found!)";
        if (colorsClot.Key==surchedCol && clotCnt.Key==surchedDres)
        {
            Console.WriteLine($"* {clotCnt.Key} - {clotCnt.Value} {isFount}");
        }
        else
        {
            Console.WriteLine($"* {clotCnt.Key} - {clotCnt.Value}");
        }
    }
}