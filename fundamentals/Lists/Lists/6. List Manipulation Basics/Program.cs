﻿List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }
    string[] commandInfo = command.Split();
    if (commandInfo[0] == "Add")
    {
        int number = int.Parse(commandInfo[1]);
        numbers.Add(number);
    }
    else if (commandInfo[0] == "Remove")
    {

        int number = int.Parse(commandInfo[1]);
        numbers.Remove(number);
    }
    else if (commandInfo[0] == "RemoveAt")
    {

        int index = int.Parse(commandInfo[1]);
        numbers.RemoveAt(index);
    }
    else if (commandInfo[0] == "Insert")
    {

        int number = int.Parse(commandInfo[1]);
        int index = int.Parse(commandInfo[2]);

        numbers.Insert(index, number);
    }

}

Console.WriteLine(String.Join(" ", numbers));