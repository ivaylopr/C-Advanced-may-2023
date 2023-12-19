int[] demensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = demensions[0];
int cols = demensions[1];
string[,] matrix = new string[rows,cols];

for (int row = 0; row < rows; row++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
	for (int col = 0; col < cols; col++)
	{
		matrix[row,col] = input[col];
	}
}
string command = String.Empty;
while ((command=Console.ReadLine())!="END")
{
	string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
	if (isValid(tokens, rows, cols))
	{
	    string temp = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
        matrix[int.Parse(tokens[1]), int.Parse(tokens[2])]= matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
		matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = temp;
		MatrixPrint(matrix);
    }
	else
	{
		Console.WriteLine("Invalid input!");
	}
}

void MatrixPrint(string[,] matrix)
{
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		for (int col = 0; col < matrix.GetLength(1); col++)
		{
			Console.Write(matrix[row,col]+" ");
		}
		Console.WriteLine();
	}
}

static bool isValid(string[] tokens, int rows, int cols)
{
	return
		tokens.Length == 5
		&& int.Parse(tokens[1]) >= 0
		&& int.Parse(tokens[1]) < rows
		&& int.Parse(tokens[2]) >= 0
		&& int.Parse(tokens[2]) < cols
        && int.Parse(tokens[3]) >= 0
        && int.Parse(tokens[3]) < rows
        && int.Parse(tokens[4]) >= 0
        && int.Parse(tokens[4]) < cols
        && tokens[0] == "swap";

}