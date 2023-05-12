
Stack<char> chars = new Stack<char>();
string name = Console.ReadLine();

foreach (var item in name)
{
    chars.Push(item);
}

while (chars.Any())
{
    char result = chars.Pop();
    Console.Write(result);
}