using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine();


string customer = "(?<customer>[A-Z][a-z]+)";
string product = @"(?<product>\w+)";
string count = @"(?<count>\d+)";
string price = @"(?<price>\d+(\.\d+)?)";
string junk = "[^|$%.]";
string pattern = @$"\%{customer}\%{junk}*\<{product}\>{junk}*\|{count}\|{junk}*?{price}\$";

decimal totalSum = 0;

StringBuilder sb = new StringBuilder();
while (input != "end of shift")
{
    MatchCollection match = Regex.Matches(input, pattern);

    foreach (Match item in match)
    {
        string customerName = item.Groups["customer"].Value;
        string productName = item.Groups["product"].Value;
        int countVal = int.Parse(item.Groups["count"].Value);
        decimal singlePrice = decimal.Parse(item.Groups["price"].Value);
        decimal clientTotal = countVal * singlePrice;
        totalSum += clientTotal;
        sb.AppendLine($"{customerName}: {productName} - {clientTotal:f2}");
    }

    input = Console.ReadLine();
}
Console.Write(sb.ToString());
Console.WriteLine($"Total income: {totalSum:F2}");