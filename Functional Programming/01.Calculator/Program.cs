
int arg1 = int.Parse(Console.ReadLine());
int arg2= int.Parse(Console.ReadLine());    
string sign = Console.ReadLine();
Func<int, int, string> operation = null;

if (sign=="+")
{
    operation = Sum;
}
else if (sign=="-")
{
    operation = Minus;
}
Console.WriteLine(operation(arg1,arg2));
string Sum(int arg1, int arg2)
{
    return $"{arg1} + {arg2} = {arg1+arg2}";
}
string Minus(int arg1, int arg2)
{
    return $"{arg1} - {arg2} = {arg1-arg2}";
}