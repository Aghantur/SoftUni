string input = Console.ReadLine();
string key = input;

while (true)
{
    string command = Console.ReadLine();

    if (command == "Generate")
    {
        break;
    }

    string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

    if (tokens[0] == "Contains")
    {
        if (key.Contains(tokens[1]))
        {
            Console.WriteLine($"{key} contains {tokens[1]}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (tokens[0] == "Flip")
    {
        int startIndex = int.Parse(tokens[2]);
        int endIndex = int.Parse(tokens[3]);

        if (tokens[1] == "Upper")
        {
            key = key.Substring(0, startIndex) + key.Substring(startIndex, endIndex - startIndex).ToUpper() + key.Substring(endIndex);
            Console.WriteLine(key);
        }
        else
        {
            key = key.Substring(0, startIndex) + key.Substring(startIndex, endIndex - startIndex).ToLower() + key.Substring(endIndex);

            Console.WriteLine(key);
        }
        

    }
    else if (tokens[0] == "Slice")
    {
        int startIndex = int.Parse(tokens[1]);
        int endIndex = int.Parse(tokens[2]);

        key = key.Remove(startIndex, endIndex - startIndex);
        Console.WriteLine(key);
    }


}

Console.WriteLine($"Your activation key is: {key}");