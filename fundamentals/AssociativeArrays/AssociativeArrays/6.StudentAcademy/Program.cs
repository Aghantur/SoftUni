Dictionary<string, List<double>> academy =
    new Dictionary<string, List<double>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();

    if (!academy.ContainsKey(name))
    {
        academy[name] = new List<double>();
    }
    double grade = double.Parse(Console.ReadLine());

    academy[name].Add(grade);
}

foreach (var name in academy)
{

    if (name.Value.Average() >= 4.5)
    {
        Console.WriteLine($"{name.Key} -> {name.Value.Average():f2}");
    }
}