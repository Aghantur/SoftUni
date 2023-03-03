Dictionary<string, List<string>> company =
    new Dictionary<string, List<string>>();


while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }
    string[] cmdArg = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

    string name = cmdArg[0];
    string id = cmdArg[1];

    if (!company.ContainsKey(name))
    {
        company[name] = new List<string>();
    }
    if (!company[name].Contains(id))
    {
        company[name].Add(id);
    }
}

foreach (var name in company)
{
    Console.WriteLine($"{name.Key}");
    foreach (var user in name.Value)
    {
        Console.WriteLine($"-- {user}");
    }
}