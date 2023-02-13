List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

bool hasChanged = false;
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
        hasChanged = true;
    }
    else if (commandInfo[0] == "Remove")
    {

        int number = int.Parse(commandInfo[1]);
        numbers.Remove(number);

        hasChanged = true;

    }
    else if (commandInfo[0] == "RemoveAt")
    {

        int index = int.Parse(commandInfo[1]);
        numbers.RemoveAt(index);

        hasChanged = true;

    }
    else if (commandInfo[0] == "Insert")
    {

        int number = int.Parse(commandInfo[1]);
        int index = int.Parse(commandInfo[2]);

        numbers.Insert(index, number);

        hasChanged = true;

    }
    else if (commandInfo[0] == "Contains")
    {
        int number = int.Parse(commandInfo[1]);

        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (commandInfo[0] == "PrintEven")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i] + " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandInfo[0] == "PrintOdd")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                Console.WriteLine(numbers[i] + " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandInfo[0] == "GetSum")
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
    }
    else if (commandInfo[0] == "Filter")
    {
        string condition = commandInfo[1];

        int number = int.Parse(Console.ReadLine());

        if (condition == "<")
        {
            foreach (var item in numbers)
            {
                if (item < number)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == ">")
        {
            foreach (var item in numbers)
            {
                if (item > number)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == ">=")
        {
            foreach (var item in numbers)
            {
                if (item >= number)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == "<=")
        {
            foreach (var item in numbers)
            {
                if (item <= number)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

    }

}
if (hasChanged)
{

    Console.WriteLine(String.Join(" ", numbers));
}