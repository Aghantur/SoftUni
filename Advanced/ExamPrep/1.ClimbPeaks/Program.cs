Stack<int> foodPortions = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> stamina = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Dictionary<string, int> peaks = new()
{
    {"Vihren",80 },
    {"Kutelo",90 },
    {"Banski Suhodol",100 },
    {"Polezhan",60 },
    {"Kamenitza",70 }

};

int days = 0;
List<string> conquered = new();
while (foodPortions.Any() && stamina.Any() && conquered.Count < 5)
{
    int currFood = foodPortions.Pop();
    int currStamina = stamina.Dequeue();
    int result = currStamina + currFood;


    foreach (var item in peaks)
    {

        if (item.Value <= result)
        {
            conquered.Add(item.Key);
            peaks.Remove(item.Key);
            break;

        }
        else
        {
            break;
        }
    }

    days++;
}

if (conquered.Count == 5)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
    Console.WriteLine("Conquered peaks: ");
    Console.WriteLine(String.Join(Environment.NewLine, conquered));
}
else if (conquered.Count == 0)
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");

}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
    Console.WriteLine("Conquered peaks: ");
    Console.WriteLine(String.Join(Environment.NewLine, conquered));

}