List<double> arr = Console.ReadLine().Split().Select(double.Parse).ToList();

for (int i = 0; i < arr.Count - 1; i++)
{
    if (arr[i] == arr[i + 1])
    {
        arr[i] += arr[i + 1];
        arr.RemoveAt(i + 1);
        i = -1;
    }
}

Console.WriteLine(string.Join(" ", arr));