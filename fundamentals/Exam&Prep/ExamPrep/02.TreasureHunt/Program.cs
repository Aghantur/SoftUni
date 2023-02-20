List<string> items = Console.ReadLine().Split('|').ToList();

string command = Console.ReadLine();

while (command != "Yohoho!")
{
    string[] commandInfo = command.Split();

    if (commandInfo[0] == "Loot")
    {
        for (int i = 1; i < commandInfo.Length; i++)
        {
            if (!items.Contains(commandInfo[i]))
            {
                items.Insert(0, commandInfo[i]);
            }
        }
    }
    else if (commandInfo[0] == "Drop")
    {
        int index = int.Parse(commandInfo[1]);

        if (index >= 0 && index < items.Count)
        {
            string currElement = items[index];
            items.RemoveAt(index);
            items.Add(currElement);
        }
    }
    else if (commandInfo[0] == "Steal")
    {
        List<string> elements = new List<string>();

        int count = int.Parse(commandInfo[1]);

        while (count > 0 && items.Count > 0)
        {
            string currElement = items[items.Count - 1];
            elements.Add(currElement);
            items.RemoveAt(items.Count - 1);


            count--;
        }
        elements.Reverse();
        Console.WriteLine(string.Join(", ", elements));
    }

    command = Console.ReadLine();
}

if (items.Count == 0)
{
    Console.WriteLine("Failed treasure hunt.");
}
else
{
    int sum = items.Sum(x => x.Length);

    double result = sum / (double)items.Count;

    Console.WriteLine($"Average treasure gain: {result:f2} pirate credits.");

}