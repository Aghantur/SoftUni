//List<string> names = new List<string>();


//names.Add("fwfw");
//names.Add("fwafw");
//names.Add("fwfbazw");

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

List<int> numbers = new List<int> { 1, 2, 3 };

List<int> oddNumber = numbers.Where(x => x % 2 != 0).ToList();
List<int> evenNumber = numbers.Where(x => x % 2 == 0).ToList();
List<int> biggerThan = numbers.Where(x => x > 4).ToList();

List<int> orderByAsc = numbers.OrderBy(x => x).ToList();
List<int> orderByDesc = numbers.OrderByDescending(x => x).ToList();

bool all = numbers.All(x => x > 0); //true


List<int> ints = new List<int> { 10, 20, 30 };
numbers.AddRange(ints);

static List<int> MyWhere(List<int> numbers) 

{
    List<int> nums = new List<int>();

	foreach (var item in numbers)
	{
		if (item%2==0)
		{
			nums.Add(item);

		}
	}
	return nums;
}