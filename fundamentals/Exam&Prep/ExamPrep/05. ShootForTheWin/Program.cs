int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
int targetShotCounter = 0;


while (true)
{
    string command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }

    int index = int.Parse(command);
    if (index < 0 || index >= targets.Length || targets[index] == -1)
    {
        continue;
    }
    int targetValue = targets[index];
    targetShotCounter++;
    targets[index] = -1;

    for (int i = 0; i < targets.Length; i++)
    {
        if (targets[i] == -1)
        {
            continue;
        }
        if (targets[i] > targetValue)
        {
            targets[i] -= targetValue;
        }
        else
        {
            targets[i] += targetValue;
        }
    }
}

Console.WriteLine($"Shot targets: {targetShotCounter} -> {string.Join(" ", targets)}");