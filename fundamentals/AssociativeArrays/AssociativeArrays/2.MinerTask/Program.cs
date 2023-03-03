Dictionary<string,int> mine = new Dictionary<string,int>();

while (true)
{
    string resourse = Console.ReadLine();

	if (resourse == "stop")
	{
		break;

	}

	int quantity = int.Parse(Console.ReadLine());
	if (!mine.ContainsKey(resourse))
	{
		mine.Add(resourse, 0);
	}
	mine[resourse] += quantity;

}

foreach (var item in mine)
{
	Console.WriteLine($"{item.Key} -> {item.Value}");
}