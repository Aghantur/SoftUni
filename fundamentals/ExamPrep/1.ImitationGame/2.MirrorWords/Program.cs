using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(@|#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
List<string> valid = new List<string>();
Regex reg = new Regex(pattern);

MatchCollection matches = reg.Matches(input);

foreach (Match match in matches)
{
    string firstWord = match.Groups[2].Value;
    string secondWord = match.Groups[3].Value;
    string reversed = new string(secondWord.Reverse().ToArray());

    if (reversed == firstWord)
    {
        valid.Add($"{firstWord} <=> {secondWord}");

    }
}

if (matches.Count == 0)
{
    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{matches.Count} word pairs found!");
}

if (valid.Count > 0)
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(string.Join(", ", valid));
}
else
{
    Console.WriteLine("No mirror words!");
}