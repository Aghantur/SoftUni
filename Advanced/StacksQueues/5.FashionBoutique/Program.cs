Stack<int> clothes = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int rackSize = int.Parse(Console.ReadLine());
int currRack = rackSize;
int racks = 1;

while (clothes.Any())
{
    currRack -= clothes.Peek();

    if (currRack < 0)
    {
        currRack = rackSize;

        racks++;

        continue;
    }

    clothes.Pop();
}
Console.WriteLine(racks);