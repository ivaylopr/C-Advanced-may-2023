
using System.Threading.Channels;

List<Person> people = new();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    people.Add(new Person() { Name = input[0],Age = int.Parse(input[1])});
}
string filterType =  Console.ReadLine();
int ageFilter=int.Parse(Console.ReadLine());
string formatType =Console.ReadLine();

Func<Person, bool> filter = GetFilterType(filterType,ageFilter);
people=people.Where(filter).ToList();
Action<Person> printer = PrintType(formatType);
foreach (var item in people)
{
    printer(item);
}
Func<Person,bool> GetFilterType(string filterT, int age)
{
    switch(filterT)
    {
        case "older": return person => person.Age >= age;
        case "younger": return person => person.Age < age;
        default: return null;
            

    }
}
Action<Person> PrintType(string formatType)
{
    switch(formatType)
    {
        case "name age":return p => Console.WriteLine($"{p.Name} - {p.Age}");
        case "age": return p => Console.WriteLine($"{p.Age}");
        case "name": return p => Console.WriteLine($"{p.Name}");
        default:
            return null;
    }    
}
class Person
{
    public string Name;
    public int Age;
}
