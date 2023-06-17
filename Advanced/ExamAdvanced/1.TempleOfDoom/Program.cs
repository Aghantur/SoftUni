Queue<int> tools = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

List<int> challenges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (true)
{

    if (!tools.Any() || !substances.Any() && challenges.Any())
    {
        break;
    }
    int curTool = tools.Dequeue();
    int currSub = substances.Pop();

    int result = currSub * curTool;

    if (challenges.Contains(result))
    {
        challenges.Remove(result);
    }
    else
    {
        curTool += 1;
        currSub -= 1;

        if (currSub == 0)
        {
            tools.Enqueue(curTool);

            continue;
           
        }
        tools.Enqueue(curTool);
        
        substances.Push(currSub);
    }

    
}

if ((!tools.Any() || !substances.Any()) && challenges.Any())
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
    if (tools.Any())
    {
        Console.WriteLine("Tools: " + string.Join(", ", tools));

    }
    if (substances.Any())
    {
        Console.WriteLine("Substances: " + string.Join(", ", substances));

    }
    if (challenges.Any())
    {
        Console.WriteLine("Challenges: " + string.Join(", ", challenges));
    }

    return;
}
Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");

if (tools.Any())
{
    Console.WriteLine("Tools: " + string.Join(", ", tools));

}
if (substances.Any())
{
    Console.WriteLine("Substances: " + string.Join(", ", substances));

}
if (challenges.Any())
{
    Console.WriteLine("Challenges: " + string.Join(", ", challenges));
}
