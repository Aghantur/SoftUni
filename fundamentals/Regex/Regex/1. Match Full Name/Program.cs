using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
Regex regex = new Regex(pattern);

MatchCollection result = regex.Matches(text);

foreach (Match item in result)
{
    Console.Write(item+ " ");
}