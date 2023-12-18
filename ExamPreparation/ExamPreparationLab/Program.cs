int[] timeTasks = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] tasksNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Queue<int> times = new Queue<int>(timeTasks);
Stack<int> tasks = new Stack<int>(tasksNumbers);
Dictionary<string, int> ducsTaken = new()
{
    {"Darth Vader Ducky",0 },
    {"Thor Ducky",0},
    {"Big Blue Rubber Ducky",0 },
    {"Small Yellow Rubber Ducky",0 }
};
while (times.Count>0 && tasks.Count>0)
{
    int currentTime = times.Dequeue();
    int currentTask = tasks.Pop();
    int result = currentTask * currentTime;
    if (result>0 && result<=60)
    {
        ducsTaken["Darth Vader Ducky"] += 1;
    }
    else if (result >= 61 && result <= 120)
    {
        ducsTaken["Thor Ducky"] += 1;
    }
    else if (result >= 121 && result <= 180)
    {
        ducsTaken["Big Blue Rubber Ducky"] += 1;
    }
    else if (result >=181 && result <= 240)
    {
        ducsTaken["Small Yellow Rubber Ducky"] += 1;
    }
    else
    {
        currentTask -= 2;
        tasks.Push(currentTask);
        times.Enqueue(currentTime);

    }
}
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded: ");
foreach (var duck in ducsTaken)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}
