using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine();

decimal total = 0;

StringBuilder sb = new StringBuilder();
Regex regex = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)");

while (input != "Purchase")
{
    Match match = regex.Match(input);

	if (match.Success)
	{
		string name = match.Groups["name"].Value;
		decimal price = decimal.Parse(match.Groups["price"].Value);
		int quantity = int.Parse(match.Groups["quantity"].Value);

		decimal sum = price* quantity;
		total += sum;
		sb.AppendLine(name);
	}

	input = Console.ReadLine();

}

Console.WriteLine("Bought furniture:");
if (sb.Length > 0)
{
	Console.Write(sb.ToString());
}
Console.WriteLine($"Total money spend: {total:f2}");