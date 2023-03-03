int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();


for (int i = 0; i < n; i++)
{
    string key = Console.ReadLine();
    string value = Console.ReadLine();


    if (!words.ContainsKey(key))
    {
        words.Add(key, new List<string>());
    }
    List<string> values = words[key];
    values.Add(value);
}

foreach (var (key,value) in words)
{
    Console.WriteLine($"{key} - {string.Join(", ",value)}");
}