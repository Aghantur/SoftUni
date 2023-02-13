List<int> wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

int maxCapacity = int.Parse(Console.ReadLine());

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    string[] number = command.Split();

    if (number.Length == 2)
    {
        int passengers = int.Parse(number[1]);
        wagons.Add(passengers);
    }
    else
    {
        int passengers = int.Parse(number[0]);

        //wagons.First(x => x + passengers <= maxCapacity);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passengers <= maxCapacity)
            {
                wagons[i] += passengers;
                break;
            }
        }

    }

}

Console.WriteLine(String.Join(" ", wagons));