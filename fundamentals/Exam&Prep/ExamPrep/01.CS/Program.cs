int energy = int.Parse(Console.ReadLine());

int wonCount = 0;
while (true)
{
    string command = Console.ReadLine();
    if (command == "End of battle")
    {
        break;
    }
    if (energy - int.Parse(command) < 0)
    {

        Console.WriteLine($"Not enough energy! Game ends with {wonCount} won battles and {energy} energy");
        return;
    }
    energy -= int.Parse(command);

    wonCount++;
    if (wonCount % 3 == 0)
    {
        energy += wonCount;
    }

}
Console.WriteLine($"Won battles: {wonCount}. Energy left: {energy}");
