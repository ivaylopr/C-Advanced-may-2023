﻿HashSet<string> names = new();
int n = int.Parse((Console.ReadLine()));

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    names.Add(name);
}
foreach (string name in names)
{
    Console.WriteLine(name);
}  
    