int dimencion = int.Parse(Console.ReadLine());
int[][] jackedArr= new int[dimencion][];

for (int row=0; row<dimencion; row++)
{
    int[] inputLine = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    jackedArr[row] = inputLine;
}

for (int row = 0; row < dimencion-1; row++)
{
    if (jackedArr[row].Length == jackedArr[row+1].Length)
    {
        for (int i = 0; i < jackedArr[row].Length; i++)
        {
            jackedArr[row][i] *= 2;
            jackedArr[row + 1][i] *= 2;
        }
    }
    else
    {
        for (int i = 0; i < jackedArr[row].Length; i++)
        {
            jackedArr[row][i] /= 2;
            
        }
        for (int i = 0; i < jackedArr[row+1].Length; i++)
        {
            jackedArr[row + 1][i] /= 2;
        }
    }
}
//JackedArrayPrint(jackedArr, dimencion);

string command = String.Empty;
while ((command=Console.ReadLine())!="End")
{
    string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string action = commandArg[0];
    int rowToAct = int.Parse(commandArg[1]);
    int colToAct = int.Parse(commandArg[2]);
    int value = int.Parse(commandArg[3]);
    if (CordinatesValidator(rowToAct, colToAct,jackedArr))
    {
        if (action=="Add")
        {
            jackedArr[rowToAct][colToAct]+=value;
        }
        else if (action=="Subtract")
        {
            jackedArr[rowToAct][colToAct] -= value;
        }
    }
}
JackedArrayPrint(jackedArr, dimencion);

static bool CordinatesValidator(int rowToAct, int colToAct,int[][] jackedArr)
{
    return
        rowToAct>=0
        && rowToAct < jackedArr.Length
        && colToAct>=0
        && colToAct < jackedArr[rowToAct].Length;
}

static void JackedArrayPrint(int[][] jackedArr, int dimencion)
{
    for (int row = 0; row < dimencion; row++)
    {
        Console.WriteLine(String.Join(" ", jackedArr[row]));
    }
}