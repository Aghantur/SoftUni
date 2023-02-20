List<string> names = Console.ReadLine().Split(", ").ToList();

int countBlackList = 0;
int countLostNames = 0;

while (true)
{
    string command = Console.ReadLine();
    string[] commands = command.Split();
    if (commands[0] == "Report")
    {
        break;
    }

    if (commands[0] == "Blacklist")
    {


        if (!names.Contains(commands[1]))
        {
            Console.WriteLine($"{commands[1]} was not found.");
        }
        else
        {
            Console.WriteLine($"{commands[1]} was blacklisted.");

            names[names.IndexOf(commands[1])] = "Blacklisted";
            countBlackList++;
        }


    }
    else if (commands[0] == "Error")
    {

        int index = int.Parse(commands[1]);
        if (index >= 0 && index <= names.Count - 1)
        {
            if (names[index] != "Blacklisted" && names[index] != "Lost")
            {
                Console.WriteLine($"{names[index]} was lost due to an error.");

                names[index] = "Lost";
                countLostNames++;
            }
            else
            {
                continue;
            }

        }
    }
    else if (commands[0] == "Change")
    {

        int index = int.Parse(commands[1]);
        if (index >= 0 && index <= names.Count - 1)
        {
            Console.WriteLine($"{names[index]} changed his username to {commands[2]}.");

            names[index] = commands[2];
        }
        else
        {
            continue;
        }
    }

}
Console.WriteLine($"Blacklisted names: {countBlackList}");
Console.WriteLine($"Lost names: {countLostNames}");
Console.WriteLine(string.Join(" ", names));