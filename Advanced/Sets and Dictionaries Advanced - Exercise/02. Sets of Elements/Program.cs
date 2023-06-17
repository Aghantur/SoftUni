HashSet<int> first = new();
HashSet<int> second = new();

int[] arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < arr[0]; i++)
{
    first.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < arr[1]; i++)
{
    second.Add(int.Parse(Console.ReadLine()));
}

first = first.Intersect(second).ToHashSet();
Console.WriteLine(String.Join(" ",first));