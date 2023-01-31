int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int even = 0;
int odd = 0;

foreach (var item in input)
{
	if (item%2==0)
	{
		even += item;
	}
	else
	{
		odd+=item;
	}
}
Console.WriteLine(even-odd);