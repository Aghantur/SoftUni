Dictionary<char, int> letters = new Dictionary<char, int>();

string input = Console.ReadLine();

foreach (var item in input)
{
	if (item == ' ')
	{
		continue;
	}

	if (!letters.ContainsKey(item))
	{
		letters[item] = 0;
	}

	letters[item]++;
}

foreach (var item in letters)
{
	Console.WriteLine($"{item.Key} -> {item.Value}");
}