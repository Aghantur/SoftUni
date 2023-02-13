List<string> numbers = Console.ReadLine().Split('|').Reverse().ToList();

for (int i = 0; i < numbers.Count; i++)
{
    List<string> ints = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
	for (int j = 0; j < ints.Count; j++)
	{
		Console.Write($"{ints[j]} ");

	}
}

//Console.WriteLine(String.Join(" ", numbers));