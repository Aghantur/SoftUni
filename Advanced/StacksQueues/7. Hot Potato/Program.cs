string[] names = Console.ReadLine().Split();

int n = int.Parse(Console.ReadLine());

Queue<string> ppl = new Queue<string>(names);

while (ppl.Count > 1)
{

	for (int i = 0; i < n - 1; i++)
	{
		ppl.Enqueue(ppl.Dequeue());
	}
	Console.WriteLine($"Removed {ppl.Dequeue()}");
}

Console.WriteLine($"Last is {ppl.Peek()}");