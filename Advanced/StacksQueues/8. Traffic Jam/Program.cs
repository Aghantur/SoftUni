

int n = int.Parse(Console.ReadLine());
int carsCount = 0;
Queue<string> traffic = new Queue<string>();

string command = Console.ReadLine();

while (command != "end")
{
    if (command != "green")
    {
        traffic.Enqueue(command);
        command = Console.ReadLine();
        continue;
    }

    int currCount = n;

    while (traffic.Count > 0 && currCount > 0)
    {
        Console.WriteLine($"{traffic.Dequeue()} passed!");
        currCount--;
        carsCount++;
    }
    command = Console.ReadLine();
}

Console.WriteLine($"{carsCount} cars passed the crossroads.");

