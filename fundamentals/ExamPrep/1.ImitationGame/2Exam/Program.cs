using System.Text;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());

string pattern = @"(?<one>.+)\>(?<digits>\d{3})\|(?<small>[a-z]{3})\|(?<big>[A-Z]{3})\|(?<symbols>[^<>]{3})\<(?<two>.+)";

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    Match match = Regex.Match(input, pattern);
    string final = string.Empty;

    if (match.Success && 
        match.Groups["one"].Length == match.Groups["two"].Length &&
        match.Groups["one"].Value == match.Groups["two"].Value)
    {
        final += string.Concat(match.Groups["digits"]);
        final += string.Concat(match.Groups["small"]);
        final += string.Concat(match.Groups["big"]);
        final += string.Concat(match.Groups["symbols"]);
        Console.WriteLine($"Password: {final}");
    }
    else
    {
        Console.WriteLine("Try another password!");
        
    }
}