string[] parametarOf = Console.ReadLine().Split();
int rows = int.Parse(parametarOf[0]);   
int cols = int.Parse(parametarOf[1]); 
int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int col = 0; col <cols; col++)
	{
		matrix[row, col] = input[col];
	}
}
int diagonalSum = 0;
