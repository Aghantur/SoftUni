int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

int average = (int)ints.Average();

int[] result = ints.Where(x => x > average).OrderByDescending(x => x).Take(5).ToArray();

if (result.Length > 0)
{
    Console.WriteLine(string.Join(" ", result));
}
else
{
    Console.WriteLine("No");
}