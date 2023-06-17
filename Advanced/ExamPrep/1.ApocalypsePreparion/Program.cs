
Queue<int> textiles = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> medikamenti = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<int, string> items = new()
{
    {30,"Patch" },
    {40,"Bandage" },
    {100,"MedKit" },

};
SortedDictionary<string, int> createdItems = new();

while (textiles.Any() && medikamenti.Any())
{
    int textile = textiles.Dequeue();
    int medicament = medikamenti.Pop();

    int sum = textile + medicament;

    if (items.ContainsKey(sum))
    {
        string healingItem = items[sum];

        if (!createdItems.ContainsKey(healingItem))
        {
            createdItems.Add(healingItem, 0);

        }
        createdItems[healingItem]++;
    }
    else if (sum > 100)
    {
        if (!createdItems.ContainsKey("MedKit"))
        {
            createdItems.Add("MedKit", 0);
        }
        createdItems["MedKit"]++;



        int nextMedikament = medikamenti.Pop() + (sum - 100);
        medikamenti.Push(nextMedikament);

    }
    else
    {
        medicament += 10;
        medikamenti.Push(medicament);
    }
}



if (!textiles.Any() && !medikamenti.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textiles.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else
{
    Console.WriteLine("Medicaments are empty.");

}

foreach (var item in createdItems.OrderByDescending(x => x.Value))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

if (textiles.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}

if (medikamenti.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medikamenti)}");

}