string[] words = Console.ReadLine().Split();
string result = string.Empty;

foreach (var item in words)
{
    int length = item.Length;

	for (int i = 0; i < length; i++)
	{
		result += item;
	}
}
Console.WriteLine(result);