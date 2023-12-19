using System.Reflection.Metadata;

string[] input = Console.ReadLine().Split();
Stack<string> expression = new Stack<string>(input.Reverse());
int result= int.Parse(expression.Pop());

while(expression.Count>0)
{
    string sing = expression.Pop();
    int num = int.Parse(expression.Pop());
    if (sing == "+")
    {
        result += num;
    }
    else if (sing == "-")
    {
        result -= num;
    }    
}
Console.WriteLine(result);
