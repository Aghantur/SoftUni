
int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int elementsToPush = tokens[0];
int elementsToPop = tokens[1];
int number = tokens[2];

Queue<int> queue = new(numbers);



for (int i = 0; i < elementsToPop; i++)
{
    queue.Dequeue();
}

if (queue.Contains(number)) 
{
    Console.WriteLine("true");
}
else
{
    if (queue.Any())
    {
        Console.WriteLine(queue.Min());

    }
    else
    {
        Console.WriteLine(0);
    }
}