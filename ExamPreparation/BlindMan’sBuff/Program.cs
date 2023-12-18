int[] size =Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n=size[0];
int m = size[1];
char[,] field = new char[n,m];
int playerRow = 0;
int playerCol = 0;


for (int row = 0; row < n; row++)
{
    string[] inputField = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < m; col++)
	{
		field[row, col] = char.Parse(inputField[col]);
		if (field[row,col]=='B')
		{
			playerCol = col;
			playerRow = row;
		}
	}
}
string command=String.Empty;
int movesCnt = 0;
int tuchedCnt = 0;
while ((command=Console.ReadLine())!="Finish")
{
	if (command=="up")
	{
		playerRow--;
        if (IsIn(playerRow, playerCol, field))
        {
            if (field[playerRow, playerCol] == 'O')
            {
                playerRow++;
                continue;
            }
            if (field[playerRow, playerCol] == 'P')
            {
                field[playerRow, playerCol] = '-';
                tuchedCnt++;
            }
            movesCnt++;
        }
        else
        {
            playerRow++;

        }
        

        
	}
	else if (command=="down" )
	{
        playerRow++;
        if (IsIn(playerRow, playerCol, field))
        {
           
            if (field[playerRow, playerCol] == 'O')
            {
                playerRow--;
                continue;
            }
            if (field[playerRow, playerCol] == 'P')
            {
                field[playerRow, playerCol] = '-';
                tuchedCnt++;
            }
            movesCnt++;
        }
        else
        {
            playerRow--;
        }
		
    }
    else if (command == "left")
    {
		playerCol--;
        if (IsIn(playerRow, playerCol, field))
        {
            if (field[playerRow, playerCol] == 'O')
            {
                playerCol++;
                continue;
            }
            if (field[playerRow, playerCol] == 'P')
            {
                field[playerRow, playerCol] = '-';
                tuchedCnt++;
            }
            movesCnt++;
        }
        else
        {
            playerCol++;
        }
        
    }
    else if (command == "right")
    {
		playerCol++;
        if (IsIn(playerRow, playerCol, field))
        {
            if (field[playerRow, playerCol] == 'O')
            {
                playerCol--;
                continue;
            }
            if (field[playerRow, playerCol] == 'P')
            {
                field[playerRow, playerCol] = '-';
                tuchedCnt++;
            }
            movesCnt++;
        }
        else
        {
            playerCol -= 1;
        }
        
    }

    if (tuchedCnt==3)
    {
        break;
    }
}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {tuchedCnt} Moves made: {movesCnt}");
static bool IsIn(int row,int col, char[,]field)
{
	bool isIn = true;
    if (row<0 || col<0 || row>field.GetLength(0)-1 || col>field.GetLength(1)-1)
	{
		isIn=false;
	}
	return isIn;
}