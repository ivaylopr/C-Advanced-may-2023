using System.Numerics;
using System.Runtime.ExceptionServices;

int cubeParametar=int.Parse(Console.ReadLine());
int[,] matrix = new int[cubeParametar, cubeParametar];

for (int row = 0; row < cubeParametar; row++)
{
	int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	for (int col = 0; col< cubeParametar; col++)
	{
		matrix[row,col] = input[col];
	}
}

int diagonalSum = 0;
for (int i = 0; i < cubeParametar; i++)
{
	diagonalSum += matrix[i, i];
}
Console.WriteLine(diagonalSum);