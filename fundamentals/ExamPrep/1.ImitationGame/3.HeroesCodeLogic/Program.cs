
using System.ComponentModel.DataAnnotations;

int n = int.Parse(Console.ReadLine());
Dictionary<string, Heroes> heroes = new Dictionary<string, Heroes>();

for (int i = 0; i < n; i++)
{
    string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string name = info[0];
    int hp = int.Parse(info[1]);
    int mana = int.Parse(info[2]);

    heroes[name] = new Heroes(name, hp, mana);

}

string input = Console.ReadLine();
while (input != "End")
{
    string[] tokens = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    if (action == "CastSpell")
    {
        string name = tokens[1];
        int mp = int.Parse(tokens[2]);
        string spellName = tokens[3];

        if (heroes.ContainsKey(name))
        {
            if (heroes[name].Mana >= mp)
            {
                heroes[name].Mana -= mp;
                Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name].Mana} MP!");
            }
            else
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
            }
        }
    }
    else if (action == "TakeDamage")
    {
        string name = tokens[1];
        int dmg = int.Parse(tokens[2]);
        string atker = tokens[3];

        heroes[name].Hp -= dmg;
        if (heroes[name].Hp <= 0)
        {
            Console.WriteLine($"{name} has been killed by {atker}!");
        }
        else
        {
            Console.WriteLine($"{name} was hit for {dmg} HP by {atker} and now has {heroes[name].Hp} HP left!");
        }
    }
    else if (action == "Recharge")
    {
        string name = tokens[1];
        int amountMp = int.Parse(tokens[2]);
        int currMp = heroes[name].Mana;
        heroes[name].Mana += amountMp;
        if (heroes[name].Mana > 200)
        {
            heroes[name].Mana = 200;
        }
        if (currMp + amountMp > 200)
        {
            Console.WriteLine($"{name} recharged for {200 - currMp} MP!");

        }
        else
        {
            Console.WriteLine($"{name} recharged for {amountMp} MP!");

        }
    }
    else if (action == "Heal")
    {
        string name = tokens[1];
        int amountHp = int.Parse(tokens[2]);
        int currHp = heroes[name].Hp;

        heroes[name].Hp += amountHp;

        if (heroes[name].Hp > 100)
        {
            heroes[name].Hp = 100;
        }
        if (currHp + amountHp > 100)
        {
            Console.WriteLine($"{name} healed for {100 - currHp} HP!");

        }
        else
        {
            Console.WriteLine($"{name} healed for {amountHp} HP!");

        }
    }


    input = Console.ReadLine();
}
foreach (var hero in heroes.Values.Where(x => x.Hp > 0))
{
    Console.WriteLine($"{hero.Name}");
    Console.WriteLine($"  HP: {hero.Hp}");
    Console.WriteLine($"  MP: {hero.Mana}");
}

class Heroes
{
    public Heroes(string name, int hp, int mana)
    {
        Name = name;
        Hp = hp;
        Mana = mana;
    }

    public string Name { get; set; }
    [Range(0, 100)]
    public int Hp { get; set; }
    [Range(0, 200)]
    public int Mana { get; set; }

}