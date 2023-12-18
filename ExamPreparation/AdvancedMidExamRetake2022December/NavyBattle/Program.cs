int size = int.Parse(Console.ReadLine());
char[,] battleField = new char[size, size];
int submarineRow = 0;
int submarineCol = 0;

for (int row = 0; row < size; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        battleField[row, col] = input[col];
        if (battleField[row, col] == 'S')
        {
            submarineRow = row;
            submarineCol = col;
        }
    }

}

int hitsTaken = 0;
int enemiesDown = 3;
while (true)
{
    battleField[submarineRow, submarineCol] = '-';
    string command = Console.ReadLine();
    if (command == "up")
    {
        submarineRow--;
    }
    else if (command == "down")
    {
        submarineRow++;
    }
    else if (command == "left")
    {
        submarineCol--;
    }
    else if (command == "right")
    {
        submarineCol++;
    }
    if (battleField[submarineRow, submarineCol] == 'C')
    {
        enemiesDown--;
    }
    else if (battleField[submarineRow, submarineCol] == '*')
    {
        hitsTaken++;
    }
    if (enemiesDown == 0)
    {
        Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");

        break;
    }
    else if (hitsTaken == 3)
    {
        Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineRow}]!");
        break;
    }
}
battleField[submarineRow, submarineCol] = 'S';
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(battleField[row, col]);
    }
    Console.WriteLine();
}