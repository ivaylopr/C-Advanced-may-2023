double[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
Func<double, double> addedVat = pr => pr + pr * 0.2;
List<double> output = new List<double>();
foreach (var item in input)
{
    output.Add(addedVat(item));
}
foreach (var item in output)
{
    Console.WriteLine($"{item:f2}");
}