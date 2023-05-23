Queue<string> setlist = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (setlist.Count > 0)
{
    
    string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

    string command = tokens[0];

    if (command == "Play")
    {
        setlist.Dequeue();
    }
    else if (command == "Add")
    {
        string song = string.Join(" ", tokens.Skip(1));

        if (setlist.Contains(song))
        {

            Console.WriteLine($"{song} is already contained!");
            continue;
        }
        else
        {
            setlist.Enqueue(song);

        }
    }
    else if (command == "Show")
    {
        Console.WriteLine(string.Join(", ", setlist));
    }
}
Console.WriteLine("No more songs!");