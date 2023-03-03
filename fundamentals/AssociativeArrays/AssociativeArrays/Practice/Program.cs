Dictionary<string, double> items = new Dictionary<string, double>();

items["banana"] = 2.5;
items["orange"] = 20.5;
items["kiwi"] = 1.5;

foreach (var item in items)
{
    Console.WriteLine(item.Key);
}