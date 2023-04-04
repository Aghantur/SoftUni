using Microsoft.VisualBasic;

string input = Console.ReadLine();

while (true)
{
    string command = Console.ReadLine();

    if (command == "Done")
    {
        break;
    }

    string[] tokens = command.Split();

    if (tokens[0] == "Change")
    {
        input = input.Replace(tokens[1], tokens[2]);
        Console.WriteLine(input);
    }
    else if (tokens[0] == "Includes")
    {
        bool isTrue = false;
        if (input.Contains(tokens[1]))
        {
            isTrue = true;
        }
        else
        {
            isTrue = false;
        }
        Console.WriteLine(isTrue);
    }
    else if (tokens[0] == "End")
    {
        bool isTrue = false;
        if (input.EndsWith(tokens[1])
)
        {
            isTrue = true;
        }
        else
        {
            isTrue = false;
        }
        Console.WriteLine(isTrue);

    }
    else if (tokens[0] == "Uppercase")
    {
        input = input.ToUpper();
        Console.WriteLine(input);
    }
    else if (tokens[0] == "FindIndex")
    {
        int index = input.IndexOf(tokens[1]);
        Console.WriteLine(index);
    }
    else if (tokens[0] == "Cut")
    {

        int startIndex = int.Parse(tokens[1]);
        int count = int.Parse(tokens[2]);

        Console.WriteLine(input.Substring(startIndex, count));
    }
}