HashSet<string> vipGuests = new HashSet<string>();
HashSet<string> regularList = new HashSet<string>();
string command = Console.ReadLine();
bool flag =  false;
while (true)
{
    if (command=="PARTY")
    {
        flag= true;
        break;
    }
    else if (command=="END")
    {
        break;
    }
    else
    {
        char isDigit = char.Parse(command[0].ToString());
        if (isDigit>=48 && isDigit<=57)
        {
            vipGuests.Add(command);
        }
        else
        {
            regularList.Add(command);
        }
    }
    command = Console.ReadLine();
}
while (flag && vipGuests.Count>0 && regularList.Count>0)
{
    string number = Console.ReadLine();
    if (vipGuests.Contains(number))
    {
        vipGuests.Remove(number);
    }
    else if (regularList.Contains(number))
    {
        regularList.Remove(number);
    }
    if (number=="END")
    {
        flag=false;
    }
}
int peopleDidntCome = vipGuests.Count + regularList.Count;
Console.WriteLine(peopleDidntCome);
foreach (var item in vipGuests)
{
    Console.WriteLine(item);
}
foreach (var item in regularList)
{
    Console.WriteLine(item);
}