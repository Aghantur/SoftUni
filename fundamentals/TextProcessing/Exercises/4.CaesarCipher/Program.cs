string text = Console.ReadLine();

char[] encrypted = new char[text.Length];

for (int i = 0; i < text.Length; i++)
{
    encrypted[i] = (char)(text[i] + 3);
}

Console.WriteLine(new string(encrypted));