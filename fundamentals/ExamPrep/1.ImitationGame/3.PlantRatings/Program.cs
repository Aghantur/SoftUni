int n = int.Parse(Console.ReadLine());

Dictionary<string, int> plants = new Dictionary<string, int>();
Dictionary<string, List<double>> ratings = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
    string[] info = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
    string name = info[0];
    int rarity = int.Parse(info[1]);

    if (!plants.ContainsKey(name))
    {
        plants.Add(name, rarity);
        ratings.Add(name, new List<double>());

    }
    else
    {
        plants[name] = rarity;
    }
}
string command = Console.ReadLine();
while (command != "Exhibition")
{
    string[] tokens = command.Trim().Split(":", StringSplitOptions.RemoveEmptyEntries);
    string commandInfo = tokens[0];
    string[] info = tokens[1].Trim().Split("-", StringSplitOptions.RemoveEmptyEntries);
    string name = info[0].Trim();

    if (!plants.ContainsKey(name))
    {
        Console.WriteLine("error");
        command = Console.ReadLine().Trim();

        continue;
    }

    if (commandInfo == "Rate")
    {
        ratings[name].Add(double.Parse(info[1].Trim()));

    }
    else if (commandInfo == "Update")
    {
        int rarity = int.Parse(info[1].Trim());
        plants[name] = rarity;
    }
    else if (commandInfo == "Reset")
    {
        ratings[name].Clear();
    }

    command = Console.ReadLine().Trim();
}

Console.WriteLine("Plants for the exhibition:");

//var sorted = plants.OrderByDescending(x => x.Value).ThenByDescending(x => ratings[x.Key].Average(x => x.));
foreach (var plant in ratings.Keys)
{
    double averageRating = 0;
    //ratings[plant].Count > 0
    //                ? ratings[plant].Average()
    //                : 0.0;
    if (ratings[plant].Count > 0)
    {
        averageRating = ratings[plant].Average();
    }
    Console.WriteLine($"- {plant}; Rarity: {plants[plant]}; Rating: {averageRating:F2}");
}