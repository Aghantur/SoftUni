string stops = Console.ReadLine();
string command = Console.ReadLine();


while (command != "Travel")
{
    string[] tokens = command.Split(":");
    string instructions = tokens.First();

    if (instructions == "Add Stop")
    {
        int index = int.Parse(tokens[1]);
        string stop = tokens[2];

        if (index >= 0 && index < stops.Length)
        {
            stops = stops.Insert(index, stop);
        }
    }
    else if (instructions == "Remove Stop")
    {
        int startIndex = int.Parse(tokens[1]);
        int endIndex = int.Parse(tokens[2]);

        if (startIndex >= 0 && startIndex < stops.Length &&
            endIndex >= 0 && endIndex < stops.Length)
        {
            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
        }

    }
    else if (instructions == "Switch")
    {
        string oldString = tokens[1];
        string newString = tokens[2];

        if (stops.Contains(oldString))
        {
            stops = stops.Replace(oldString, newString);
        }
    }
    Console.WriteLine(stops);
    command = Console.ReadLine();
}

Console.WriteLine($"Ready for world tour! Planned stops: {stops}");