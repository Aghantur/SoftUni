
Dictionary<string, Town> towns = new Dictionary<string, Town>();

while (true)
{
    string command = Console.ReadLine();

    if (command == "Sail")
    {
        break;
    }

    string[] tokens = command.Split("||", StringSplitOptions.RemoveEmptyEntries);

    string name = tokens[0];
    int pop = int.Parse(tokens[1]);
    int gold = int.Parse(tokens[2]);
    if (towns.ContainsKey(name))
    {
        towns[name].Pop += pop;
        towns[name].Gold += gold;
    }
    else
    {
        towns[name] = new Town(pop, gold);

    }

}
while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }
    string[] tokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
    string cmd = tokens[0];
    string town = tokens[1];

    if (cmd == "Plunder")
    {
        Console.WriteLine($"{town} plundered! {tokens[3]} gold stolen, {tokens[2]} citizens killed.");
        towns[town].Pop -= int.Parse(tokens[2]);
        towns[town].Gold -= int.Parse(tokens[3]);

        if (towns[town].Gold <= 0 || towns[town].Pop <= 0)
        {
            Console.WriteLine($"{town} has been wiped off the map!");
            towns.Remove(town);
        }
    }
    else if (cmd == "Prosper")
    {

        if (int.Parse(tokens[2]) <= 0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
            continue;
        }
        towns[town].Gold += int.Parse(tokens[2]);

        Console.WriteLine($"{tokens[2]} gold added to the city treasury. {town} now has {towns[town].Gold} gold.");
    }
}

if (towns.Count != 0)
{
    Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");

    foreach (var item in towns)
    {
        Console.WriteLine($"{item.Key} -> Population: {item.Value.Pop} citizens, Gold: {item.Value.Gold} kg");
    }
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}
class Town
{
    public Town(int pop, int gold)
    {
        this.Pop = pop;
        this.Gold = gold;
    }

    //public string Name { get; set; }
    public int Pop { get; set; }
    public int Gold { get; set; }
}