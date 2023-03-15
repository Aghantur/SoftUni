string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

foreach (var name in input)
{
    if (isUserValid(name))
    {
        Console.WriteLine(name);
    }
}

bool isUserValid(string name)
{
    if (name.Length < 3 || name.Length > 16)
    {
        return false;
    }
    foreach (var item in name)
    {
        if (item != '_' && item != '-'
            && ((item < 'a' || item > 'z')
            && (item < 'A' || item > 'Z')
            && (item < '0' || item > '9')))
        {
            return false;
        }
    }
    return true;
}