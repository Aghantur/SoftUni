using System.Text;

int number = int.Parse(Console.ReadLine());
List<Team> teams = new List<Team>();

for (int i = 0; i < number; i++)
{
    string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string user = input[0];
    string teamName = input[1];

    if (teams.Select(x => x.Name).Contains(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }
    if (teams.Select(x => x.Creator).Contains(user))
    {
        Console.WriteLine($"{user} cannot create another team!");
        continue;
    }

    Team team = new Team(teamName, user);

    teams.Add(team);
    Console.WriteLine($"Team {teamName} has been created by {user}!");
}

while (true)
{
    string input = Console.ReadLine();

    if (input == "end of assignment")
    {
        break;
    }

    string[] inputArr = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string member = inputArr[0];
    string teamName = inputArr[1];

    Team team = teams.FirstOrDefault(x => x.Name == teamName);
    if (team is null)
    {
        Console.WriteLine($"Team {teamName} does not exist!");
        continue;
    }

    if (team.Creator == member || teams.SelectMany(x => x.Members).Contains(member))
    {
        Console.WriteLine($"Member {member} cannot join team {teamName}!");
        continue;
    }
    team.Members.Add(member);


}
List<Team> orderedBy = teams.Where(x => x.Members.Count != 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();
List<Team> disband = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name).ToList();

foreach (Team team in orderedBy)
{
    Console.WriteLine(team);
}
Console.WriteLine("Teams to disband:");
foreach (var team in disband)
{
    Console.WriteLine(team.Name);
}

class Team
{
    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
    }

    public string Name { get; set; }
    public string Creator { get; set; }

    public List<string> Members { get; set; } = new List<string>();

    public override string ToString()
    {

        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Name);
        sb.AppendLine($"- {Creator}");


        List<string> orderedMembers = Members.OrderBy(x => x).ToList();
        foreach (var member in orderedMembers)
        {
            sb.AppendLine($"-- {member}");
        }
        return sb.ToString().TrimEnd('\n');
    }

}