int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>(input);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] commandInfo = command.Split();

    if (commandInfo[0] == "add")
    {
        int[] numbers = commandInfo.Skip(1).Select(int.Parse).ToArray();

        foreach (var item in numbers)
        {
            stack.Push(item);
        }
    }
    else if (commandInfo[0] == "remove")
    {
        int n = int.Parse(commandInfo[1]);


        while (n > 0 && n <= stack.Count)
        {

            stack.Pop();
            n--;
        }

    }
    command = Console.ReadLine().ToLower();
}

Console.WriteLine($"Sum: "+ stack.Sum());