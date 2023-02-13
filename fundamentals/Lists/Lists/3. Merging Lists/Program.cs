List<int> left = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> right = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();
int min = Math.Min(left.Count, right.Count);

for (int i = 0; i < min; i++)
{
    result.Add(left[i]);
    result.Add(right[i]);
}

if (left.Count > right.Count)
{
    for (int i = min; i < left.Count; i++)
    {
        result.Add(left[i]);
    }
}
else
{
    for (int i = min; i < right.Count; i++)
    {
        result.Add(right[i]);
    }
}

Console.WriteLine(String.Join(" ", result));