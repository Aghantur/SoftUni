List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
int sum = 0;


List<int> Copy = new List<int>();
for (int i = 0; i < arr.Count / 2; i++)
{

    int currSum = arr[i] + arr[arr.Count - 1 - i];
    Copy.Add(currSum);

}
if (arr.Count % 2 != 0)
{
    Copy.Add(arr[arr.Count / 2]);
}

Console.WriteLine(string.Join(" ", Copy));