
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> ints = new Queue<int>(numbers);
string result = string.Empty;
while (ints.Count > 0)
{
    int number = ints.Dequeue();

    if (number % 2 == 0)
    {
        result += $"{number}, ";
    }
}

Console.WriteLine(result.TrimEnd(' ', ','));