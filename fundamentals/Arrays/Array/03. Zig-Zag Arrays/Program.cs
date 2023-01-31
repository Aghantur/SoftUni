int n = int.Parse(Console.ReadLine());

int[] arr1 = new int[n];
int[] arr2 = new int[n];

for (int i = 0; i < n; i++)
{
    int[] currentInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
	if (i%2==0)
	{
		arr1[i] = currentInput[0];
		arr2[i] = currentInput[1];
	}
	else
	{
		arr1[i]=currentInput[1];
		arr2[i]=currentInput[0];
	}

}

Console.WriteLine(String.Join(" ", arr1));
Console.WriteLine(String.Join(" ", arr2));