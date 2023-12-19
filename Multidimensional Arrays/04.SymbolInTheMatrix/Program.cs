int parametar = int.Parse(Console.ReadLine());
int[,] matrix = new int[parametar,parametar];

for (int row = 0; row < parametar; row++)
{
	string input = Console.ReadLine();
	for (int col = 0; col < parametar; col++)
	{
		char element = input[col];

		matrix[row, col] = element;
	}
}
char surcherEl = char.Parse(Console.ReadLine());
int rowEl = -1;
int colEl = -1;
for (int row = 0; row < parametar; row++)
{
    for (int col = 0; col < parametar; col++)
    {
		if (matrix[row,col]==surcherEl)
		{
			rowEl = row;
			colEl = col;
		}
    }
}
if (rowEl>=0 && colEl>=0)
{
	Console.WriteLine($"({rowEl}, {colEl})");
}
else
{
	Console.WriteLine($"{surcherEl} does not occur in the matrix");
}