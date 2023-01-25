int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int pokeCount = 0;
int n1 = n;
while (n >= m)
{
    n -= m;
    pokeCount++;
    if (n == (n1 / 2) )
    {
        if (y != 0)
        {
            n /= y;
        }
    }
}

Console.WriteLine(n);
Console.WriteLine(pokeCount);
