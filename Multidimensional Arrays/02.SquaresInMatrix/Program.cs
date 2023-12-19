﻿int[] demencions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
char[,] matrix = new char[demencions[0], demencions[1]];
int cnt = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		matrix[row, col] = input[col];
	}
}
for (int row = 0; row < matrix.GetLength(0)-1; row++)
{
    for (int col = 0; col < matrix.GetLength(1)-1; col++)
    {
		if (matrix[row, col] == matrix[row,col+1] && matrix[row, col] == matrix[row+1,col+1]
			&& matrix[row, col] == matrix[row+1,col])
		{
			cnt++;
		}
    }
}
Console.WriteLine(cnt);