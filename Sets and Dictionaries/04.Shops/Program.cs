using System;

Dictionary<string, Dictionary<string, double>> shops = new();
string command = String.Empty;

while ((command=Console.ReadLine())!= "Revision")
{
    string[] commArg = command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
    string shop = commArg[0];
    string product = commArg[1];    
    double price = double.Parse(commArg[2]);
    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }
    if (!shops[shop].ContainsKey(product))
    {
        shops[shop].Add(product, price);
    }
    shops[shop][product] = price;

}
shops=shops.OrderBy(key=>key.Key).ToDictionary(x=>x.Key,x=>x.Value);    
foreach (var (shop,product) in shops)
{
    Console.WriteLine($"{shop}->");
    foreach (var (productsN,price) in product)
    {
        Console.WriteLine($"Product: {productsN}, Price: {price}");
    }
}