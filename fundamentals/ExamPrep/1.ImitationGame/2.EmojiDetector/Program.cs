
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(\:|\*)\1+(?<letters>[A-Z][a-z]{2,})\1\1";

int coolness = 0;
long threshold = 1;

for (int i = 0; i < input.Length; i++)
{

    if (char.IsDigit(input[i]))
    {
        threshold *= int.Parse(input[i].ToString());

    }
}

MatchCollection matches = Regex.Matches(input, pattern);
List<string> coolEmoji = new List<string>();
for (int i = 0; i < matches.Count; i++)
{
    string emoji = matches[i].Groups["letters"].Value;
    for (int j = 0; j < emoji.Length; j++)
    {
        coolness += emoji[j];
    }

    if (coolness > threshold)
    {
        coolEmoji.Add(matches[i].Value);
    }

    coolness = 0;
}

Console.WriteLine($"Cool threshold: {threshold}");
Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

foreach (var item in coolEmoji)
{
    Console.WriteLine(item);
}