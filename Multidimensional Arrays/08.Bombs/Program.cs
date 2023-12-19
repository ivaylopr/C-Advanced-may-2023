int dimencion = int.Parse(Console.ReadLine());
int[,] matrix = new int[dimencion,dimencion];
for (int row = 0; row < dimencion; row++)
{
    int[] input = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).ToArray();
    for (int col = 0; col < dimencion; col++)
    {
        matrix[row,col] = input[col];
    }
}
string[] coordinates = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
foreach (var coordPair in coordinates)
{
    string[] cordinates = coordPair
        .Split(",", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    int row = int.Parse(cordinates[0]);
    int col = int.Parse(cordinates[1]);
    Explode(row, col, matrix);
}
int aliveCells = 0;
int sum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row,col]>0)
        {
            sum += matrix[row, col];
            aliveCells++;
        }
    }
}
Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]+" ");
    }
    Console.WriteLine();
}
static void Explode(int row, int col, int[,] matrix)
{
    int value = matrix[row,col];
    //top
    if (value > 0)
    {
        matrix[row, col] = 0;

        if (row > 0 && matrix[row - 1, col] > 0)
        {
            matrix[row - 1, col] -= value;
        }
        //bottom
        if (row < matrix.GetLength(0)-1 && matrix[row + 1, col] > 0)
        {
            matrix[row + 1, col] -= value;
        }
        //left
        if (col > 0 && matrix[row, col - 1] > 0)
        {
            matrix[row, col - 1] -= value;
        }
        //right
        if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] > 0)
        {
            matrix[row, col + 1] -= value;
        }
        //topleft
        if (col > 0 && row > 0 && matrix[row - 1, col - 1] > 0)
        {
            matrix[row - 1, col - 1] -= value;
        }
        //topright
        if (col < matrix.GetLength(1)-1 && row > 0 && matrix[row - 1, col + 1] > 0)
        {
            matrix[row - 1, col + 1] -= value;
        }
        //bottomleft
        if (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row + 1, col - 1] > 0)
        {
            matrix[row + 1, col - 1] -= value;
        }
        //bottomright
        if (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row + 1, col + 1] > 0)
        {
            matrix[row + 1, col + 1] -= value;
        }
    }
}