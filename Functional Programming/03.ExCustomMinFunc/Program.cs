using System.Reflection.Metadata.Ecma335;

HashSet<int> inNum = Console.ReadLine().Split(" ").Select(int.Parse).ToHashSet();
Func<HashSet<int>,int> min= input=>
    {
        int min = int.MaxValue;
        foreach (var i in inNum)
        {
            if (i<min)
            {
                min = i;
            }
        }
        return min;
    };
Console.WriteLine(min(inNum));