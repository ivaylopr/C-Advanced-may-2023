using System.Data;

int rows = int.Parse(Console.ReadLine());
int[][] jacked = new int[rows][];   
for (int i = 0; i < rows; i++)
{
    jacked[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
}
string command = Console.ReadLine().ToLower();

while (command!="end")
{
    string[] commArg = command.Split(' ');
    int row = int.Parse(commArg[1]);
    int col = int.Parse(commArg[2]);
    int value = int.Parse(commArg[3]);

    bool isValid = true;
    if (row<0||jacked.Length<=row)
    {
        isValid = false;
    }
    else
    {
        if (jacked[row].Length<=col || col<0)
        {
            isValid = false;
        }

    }
    if (isValid)
    {
        if (commArg[0] == "add")
        {
            jacked[row][col] += value;
        }
        else
        {
            jacked[row][col] -= value;

        }
    }
    else
    {
        Console.WriteLine("Invalid coordinates");
    }
    command = Console.ReadLine().ToLower();
}
for (int row = 0; row < jacked.Length; row++)
{
    Console.WriteLine(String.Join(" ", jacked[row]));
}