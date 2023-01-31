string[] names = Console.ReadLine().Split(' ').ToArray();

for (int i = 0; i < names.Length/2; i++)
{
    string first = names[i];
    string last = names[names.Length - 1 - i];

    names[i] = last;
    names[names.Length-1-i]=first;
}
Console.WriteLine(string.Join(" ", names));