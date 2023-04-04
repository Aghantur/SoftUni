
using System.Xml.Linq;

Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
Dictionary<string, int> hungry = new Dictionary<string, int>();


while (true)
{
    string command = Console.ReadLine();

	if (command == "EndDay")
	{
		break;
	}

	string[] tokens = command.Split(":",StringSplitOptions.RemoveEmptyEntries);
    string[] animalInfo = tokens[1].Split("-",StringSplitOptions.RemoveEmptyEntries);
    string name = animalInfo[0];

	if (tokens[0] == "Add")
	{
        int food = int.Parse(animalInfo[1]);
        string area = animalInfo[2];
        if (!animals.ContainsKey(name))
        {
            animals[name] = new Animal(name, food, area);

        }
        else
        {
            animals[name].FoodNeeded += food;
        }
    }
    else if (tokens[0] == "Feed")
    {

        int food = int.Parse(animalInfo[1]);
        if (!animals.ContainsKey(name))
        {
            continue;
        }
        else
        {
            animals[name].FoodNeeded -= food;
            if (animals[name].FoodNeeded <= 0)
            {
                animals[name].FoodNeeded = 0;
                Console.WriteLine($"{name} was successfully fed");
                animals.Remove(name);
            }
        }
        
    }

    
}
foreach (var item in animals)
{
    if (item.Value.FoodNeeded > 0)
    {
        if (!hungry.ContainsKey(item.Value.Area))
        {
            hungry.Add(item.Value.Area, 1);
        }
        else
        {
            hungry[item.Value.Area] += 1;
        }
    }
}
Console.WriteLine("Animals:");
foreach (var item in animals)
{
    Console.WriteLine($" {item.Key} -> {item.Value.FoodNeeded}g");
}
Console.WriteLine("Areas with hungry animals:");
foreach (var item in hungry)
{
    Console.WriteLine($" {item.Key}: {item.Value}");

}

class Animal
{
    public Animal(string name, int foodNeeded, string area)
    {
        Name = name;
        FoodNeeded = foodNeeded;
        Area = area;
    }

    public string Name { get; set; }
	public int FoodNeeded { get; set; }
	public string Area { get; set; }

}