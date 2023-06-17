SortedSet<string> elements = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    elements.UnionWith(arr);
}

Console.WriteLine(String.Join(" ",elements));