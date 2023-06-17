namespace tilemaster_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> greyTiles = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> whiteTiles = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<string, int> items = new()
{
    {"Sink", 0 },
    {"Oven",0 },
    {"Countertop",0 },
    {"Wall",0 },
    {"Floor",0 }

};

            while ((greyTiles.Any() && whiteTiles.Any()) || greyTiles.Any() || whiteTiles.Any())
            {

                int grey = greyTiles.Dequeue();
                int white = whiteTiles.Pop();

                if (grey == white)
                {
                    int result = grey + white;

                    if (result == 40)
                    {
                        items["Sink"] += 1;
                    }
                    else if (result == 50)
                    {
                        items["Oven"] += 1;

                    }
                    else if (result == 60)
                    {
                        items["Countertop"] += 1;

                    }
                    else if (result == 70)
                    {
                        items["Wall"] += 1;

                    }
                    else
                    {
                        items["Floor"] += 1;

                    }
                }
                else
                {
                    white /= 2;
                    whiteTiles.Push(white);
                    greyTiles.Enqueue(grey);
                }

            }
            if (!whiteTiles.Any())
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {whiteTiles.Count}");
            }
            if (!greyTiles.Any())
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {greyTiles.Count}");
            }

            foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}