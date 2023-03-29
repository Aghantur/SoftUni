using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
Regex regex = new Regex(pattern);

MatchCollection result = regex.Matches(text);

foreach (Match item in result)
{
    Console.WriteLine($"Day: {item.Groups["day"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
}