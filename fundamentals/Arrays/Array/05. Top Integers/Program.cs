int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < arr.Length; i++)
{
    bool istop = true;

	for (int j = i+1; j < arr.Length; j++)
	{
		if (arr[i] <= arr[j])
		{
			istop = false;
			break;
		}
	}
	if (istop)
	{
		Console.Write($"{arr[i]} ");
	}
}