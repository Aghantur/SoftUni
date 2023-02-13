List<int> number = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (true)
{
    string input = Console.ReadLine();
    if (input == "End")
    {
        break;
    }
    string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string commandType = commands[0];

    switch (commandType)
    {

        case "Add":
            number.Add(int.Parse(commands[1]));
            break;
        case "Insert":
            if (int.Parse(commands[2]) <= number.Count - 1 && int.Parse(commands[2]) >= 0)
            {
                number.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                break;
            }
            else
            {

                Console.WriteLine("Invalid index");
            }
            break;

        case "Remove":
            if (int.Parse(commands[1]) <= number.Count - 1 && int.Parse(commands[1]) >= 0)
            {

                number.RemoveAt(int.Parse(commands[1]));
                break;
            }
            else
            {

                Console.WriteLine("Invalid index");
            }

            break;

        case "Shift":
            if (commands[1] == "left")
            {
                int count = int.Parse(commands[2]);

                for (int i = 0; i < count; i++)
                {
                    int firstNum = number[0];
                    number.RemoveAt(0);
                    number.Add(firstNum);
                }


            }
            else if (commands[1] == "right")
            {

                int count = int.Parse(commands[2]);
                for (int i = 0; i < count; i++)
                {
                    int lastNum = number.Count - 1;
                    number.RemoveAt(number.Count - 1);
                    number.Insert(0, lastNum);
                }
            }
            break;
        default:
            break;
    }
}
Console.WriteLine(string.Join(" ", number));