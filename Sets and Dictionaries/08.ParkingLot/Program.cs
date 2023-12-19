HashSet<string> carReg = new();
string command = String.Empty;

while ((command=Console.ReadLine())!="END")
{
    string[] commArg = command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
    string com = commArg[0].ToUpper();    
    string regNum = commArg[1].ToUpper();
    if (com=="IN")
    {
        carReg.Add(regNum);
    }
    else if (com=="OUT")
    {
        carReg.Remove(regNum);
    }
}
if (carReg.Count>0)
{
    foreach (var item in carReg)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}