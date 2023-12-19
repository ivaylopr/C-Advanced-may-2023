int[] demensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = demensions[0];
int cols = demensions[1];
char[,] matrix = new char[rows, cols];
string word = Console.ReadLine();
int currWordIdx = 0;

for (int row = 0; row < rows; row++)
{
	if (row%2==0)
	{
		
        for (int col = 0; col < cols; col++)
        {
            if (currWordIdx == word.Length)
            {
                currWordIdx = 0;
            }
            matrix[row, col] = word[currWordIdx];
            currWordIdx++;

        }
    }
	else
	{
		for (int col = cols-1; col >=0; col--)
		{
            if (currWordIdx == word.Length)
            {
                currWordIdx = 0;
            }
            matrix[row, col] = word[currWordIdx];
            currWordIdx++;
        }
	}
	
}
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}