using System.Numerics;
using System.Text.RegularExpressions;


int n = int.Parse(Console.ReadLine());
string pattern = @"\@(\#{1,})+(?<bar>[A-Z][A-Za-z0-9]{4,}[A-Z])\@\1+";
Regex digit = new Regex(@"\d");


for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    Match match = Regex.Match(input, pattern);

    if (match.Success)
    {
        string barcode = match.Groups["bar"].Value;
        MatchCollection digits = digit.Matches(barcode);

        string final = string.Empty;

        foreach (Match item in digits)
        {
            if (item.Success)
            {
                final += item.Value;
            }
        }
        if (final.Length == 0 )
        {
            final = "00";
        }
        Console.WriteLine($"Product group: {final}");
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
    
    
}