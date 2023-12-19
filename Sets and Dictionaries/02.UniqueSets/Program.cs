using System.Collections.Generic;

int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = nums[0];
int m = nums[1];
HashSet<int> secondN = new HashSet<int>();
HashSet<int> firstN = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    firstN.Add(input);
}
for (int i = 0; i < m; i++)
{
    int input = int.Parse(Console.ReadLine());
    secondN.Add(input);
}

firstN.IntersectWith(secondN);
Console.WriteLine(string.Join(" ",firstN));