int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];
int primery = 0;
int secondary = 0;

for (int row = 0; row < size; row++)
{
    int[] inputN = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	for (int col = 0; col < size; col++)
	{
		matrix[row, col] = inputN[col];
	}
}
for (int i = 0; i < size; i++)
{
	primery += matrix[i, i];
	secondary += matrix[size - i - 1, i];
}
Console.WriteLine(Math.Abs(primery-secondary));
