using System.Runtime.CompilerServices;

SortedDictionary<char, int> charCounts = new();

string input = Console.ReadLine();

foreach (var item in input)
{
    if (!charCounts.ContainsKey(item))
    {
        charCounts.Add(item, 0);
    }

    charCounts[item]++;

}

foreach (var item in charCounts)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}