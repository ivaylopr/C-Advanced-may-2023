string[] parametars = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(parametars[0]);
int cols = int.Parse(parametars[1]);
int[,] matrix = new int[rows, cols];
int sumOfMatrix = 0;

for (int row = 0; row < rows; row++)
{
	int[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = input[col];
		sumOfMatrix += input[col];
	}
}
Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sumOfMatrix);