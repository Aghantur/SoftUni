using System.Text.RegularExpressions;

var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(demon => new Demon(demon)).OrderBy(demon => demon.Name);


foreach (var demon in demons)
{
    Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
}


class Demon
{

    public Demon(string name)
    {
        Name = name;
        Health = CalculateHp(name);
        Damage = CalculateDmg(name);
    }

    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }

    private int CalculateHp(string name)
    {
        string pattern = @"[^\+\-\*\/\.\,0-9 ]";
        MatchCollection matches = Regex.Matches(name, pattern);
        int health = 0;

        foreach (Match match in matches)
        {
            char current = char.Parse(match.Value);
            health += current;
        }
        return health;
    }
    private double CalculateDmg(string name)
    {
        string pattern = @"-?\d+(\.?\d+)?";
        MatchCollection matches = Regex.Matches(name, pattern);
        var baseDmg = matches.Select(d => double.Parse(d.Value)).Sum();

        foreach (char c in name)
        {
            if (c == '*')
            {
                baseDmg *= 2;
            }
            else if (c == '/')
            {
                baseDmg /= 2;
            }
        }

        return baseDmg;
    }
}