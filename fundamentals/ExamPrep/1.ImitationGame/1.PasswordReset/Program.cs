using System.Text;

string password = Console.ReadLine();
StringBuilder sb = new StringBuilder();

while (true)
{
    string input = Console.ReadLine();

	if (input == "Done")
	{
		break;
	}

	string[] commands = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
	string info = commands[0];

	if (info == "TakeOdd")
	{
		for (int i = 1; i < password.Length; i+=2)
		{
			sb.Append(password[i]);
		}
		password = sb.ToString();
		Console.WriteLine(password);
	}
	else if (info == "Cut")
	{
		int startIndex = int.Parse(commands[1]);
		int endIndex = int.Parse(commands[2]);

		password = password.Remove(startIndex, endIndex);
		Console.WriteLine(password);

	}
	else if (info == "Substitute")
	{

		if (password.Contains(commands[1]))
		{
			password = password.Replace(commands[1], commands[2]);
			Console.WriteLine(password);
		}
		else
		{
			Console.WriteLine("Nothing to replace!");
		}
    }
}
Console.WriteLine($"Your password is: {password}");