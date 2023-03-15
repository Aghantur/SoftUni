using System.Text;

string input = Console.ReadLine();

StringBuilder sb = new StringBuilder();
int explosion = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        explosion += int.Parse(input[i + 1].ToString());
        sb.Append('>');
    }
    else if (explosion > 0)
    {
        explosion--;
    }
    else
    {
        sb.Append(input[i]);
    }
}
Console.WriteLine(sb.ToString());