string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<string,bool> predicate = x=>Char.IsUpper(x[0]);
string[] upperCaseWords = text.Where(predicate).ToArray(); 
foreach (string word in upperCaseWords)
{
    Console.WriteLine(word);
}