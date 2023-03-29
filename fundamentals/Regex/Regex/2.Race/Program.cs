using System.Text.RegularExpressions;

string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> results = new Dictionary<string, int>();

foreach (string participant in participants)
{
    results.Add(participant, 0);
}

string input = Console.ReadLine();

while (input != "end of race")
{
    MatchCollection nameRegColl = Regex.Matches(input, @"([A-Za-z]+)");
    MatchCollection distance = Regex.Matches(input, @"(\d)");

    string name = string.Join(string.Empty, nameRegColl);
    if (results.ContainsKey(name))
    {
        results[name] += distance.Select(x => int.Parse(x.Value)).Sum();
    }
    input = Console.ReadLine();
}

var finalists = results.OrderByDescending(x => x.Value).Take(3);

int counter = 1;
foreach (var item in finalists)
{
    string suffix = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
    Console.WriteLine($"{counter++}{suffix} place: {item.Key}");
}