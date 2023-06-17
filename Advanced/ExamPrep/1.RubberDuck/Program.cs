int[] programmerTime = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] numberOfTasks = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> times = new(programmerTime);
Stack<int> tasks = new(numberOfTasks);

Dictionary<string,int> rubberDucks = new Dictionary<string, int>()
{
    {"Darth Vader Ducky", 0},
    {"Thor Ducky",0 },
    {"Big Blue Rubber Ducky",0 },
    { "Small Yellow Rubber Ducky", 0 }
};

while (times.Count >0 && tasks.Count > 0)
{

    int currentTime = times.Dequeue();
    int currentTasks = tasks.Pop();

    int result = currentTasks * currentTime;

    if (result >= 0 && result<= 60)
    {
        rubberDucks["Darth Vader Ducky"] += 1;
    }
    else if (result >= 61 && result <= 120)
    {
        rubberDucks["Thor Ducky"] += 1;

    }
    else if (result >= 121 && result <= 180)
    {
        rubberDucks["Big Blue Rubber Ducky"] += 1;

    }
    else if (result >= 181 && result <= 240)
    {
        rubberDucks["Small Yellow Rubber Ducky"] += 1;

    }
    else
    {
        currentTasks -= 2;
        tasks.Push(currentTasks);
        times.Enqueue(currentTime);
    }

}

Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded: ");

foreach (var item in rubberDucks)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}