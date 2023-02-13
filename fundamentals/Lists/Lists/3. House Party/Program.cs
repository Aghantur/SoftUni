int n = int.Parse(Console.ReadLine());

List<string> names = new List<string>();

for (int i = 0; i < n; i++)
{
    string[] name = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (name.Length == 3) 
    {
        if (names.Contains(name[0]))
        {
            Console.WriteLine($"{name[0]} is already in the list!");
        }
        else
        {

            names.Add(name[0]);
        }

    }
    else if (name.Length==4)
    {
        if (!names.Contains(name[0]))
        {
            Console.WriteLine($"{name[0]} is not in the list!");
        }
        else
        {

            names.Remove(name[0]);
        }
    }

}
Console.WriteLine();
Console.WriteLine(string.Join(Environment.NewLine, names));