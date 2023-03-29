using System.Text.RegularExpressions;

string text = Console.ReadLine();

string emailRegex = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";

MatchCollection matches = Regex.Matches(text, emailRegex);

foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}