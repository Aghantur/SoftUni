
int count = int.Parse(Console.ReadLine());

Stack<int> stack = new();

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
    string command = tokens[0];

    if (command == "1")
    {
        int number = int.Parse(tokens[1]);
        stack.Push(number);
    }
    else if (command == "2")
    {
        stack.Pop();
    }
    else if (command == "3")
    {

        if (stack.Any())
        {
            Console.WriteLine(stack.Max());

        }
        continue;
    }
    else if (command == "4")
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Min());

        }
        continue;
    }

}
Console.WriteLine(string.Join(", ", stack));
