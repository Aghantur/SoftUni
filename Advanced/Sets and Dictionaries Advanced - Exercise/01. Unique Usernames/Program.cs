
HashSet<string> usernames = new();
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string username = Console.ReadLine();

    usernames.Add(username);
}

foreach (var item in usernames)
{
    Console.WriteLine(item);
}