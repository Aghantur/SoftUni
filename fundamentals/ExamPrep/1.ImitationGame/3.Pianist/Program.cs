int n = int.Parse(Console.ReadLine());
Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] info = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
    string name = info[0];
    string composer = info[1];
    string key = info[2];

    pieces[name] = new Piece(name, composer, key);

}

string commands = Console.ReadLine();
while (commands != "Stop")
{
    string[] tokens = commands.Split("|", StringSplitOptions.RemoveEmptyEntries);
    string command = tokens[0];
    string name = tokens[1];

    if (command == "Add")
    {
        if (!pieces.ContainsKey(name))
        {

            string composer = tokens[2];
            string key = tokens[3];

            pieces[name] = new Piece(name, composer, key);
            Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
        }
        else
        {
            Console.WriteLine($"{name} is already in the collection!");
        }
    }
    else if (command == "Remove")
    {
        if (pieces.ContainsKey(name))
        {
            pieces.Remove(name);
            Console.WriteLine($"Successfully removed {name}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
        }
    }
    else if (command == "ChangeKey")
    {
        string newKey = tokens[2];
        if (pieces.ContainsKey(name))
        {
            pieces[name].Key = newKey;
            Console.WriteLine($"Changed the key of {name} to {newKey}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
        }
    }
    commands = Console.ReadLine();
}
foreach (var piece in pieces.Values)
{
    Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
}

class Piece
{
    public Piece(string name, string composer, string key)
    {
        this.Name = name;
        this.Composer = composer;
        this.Key = key;
    }

    public string Name { get; set; }
    public string Composer { get; set; }
    public string Key { get; set; }


}