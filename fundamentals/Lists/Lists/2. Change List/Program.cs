List<int> ints = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }
    string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (commands[0] == "Delete")
    {

        int element = int.Parse(commands[1]);
        ints.RemoveAll(x=> x == element);
    }
    else if (commands[0] == "Insert")
    {

        int index = int.Parse(commands[2]);
        int element = int.Parse(commands[1]);

        ints.Insert(index,element);
    }
}

Console.WriteLine(string.Join(" ", ints));