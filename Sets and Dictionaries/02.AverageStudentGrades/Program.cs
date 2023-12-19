int studentsN = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> grades
    = new Dictionary<string, List<decimal>>();   

for (int i = 0; i < studentsN; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string studentName = input[0];  
    decimal grade = decimal.Parse(input[1]);
    if (!grades.ContainsKey(studentName))
    {
        grades.Add(studentName,new List<decimal>());
    }
    grades[studentName].Add(grade);
}

foreach (var item in grades)
{
    Console.Write($"{item.Key} -> ");
    foreach (var grade in item.Value)
    {
        Console.Write($"{grade:f2} ");
    }

    Console.WriteLine($"(avg: {item.Value.Average():F2})" ); 
}