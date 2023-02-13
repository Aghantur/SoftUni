List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

foreach (var item in numbers)
{
	if (item >=0)
	{
		result.Add(item);
	}
}


if (result.Count>0)
{

    result.Reverse();
    Console.WriteLine(String.Join(" ", result));
}
else
{
	Console.WriteLine("empty");
}