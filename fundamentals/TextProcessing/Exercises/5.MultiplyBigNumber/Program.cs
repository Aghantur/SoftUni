string bigNumber = Console.ReadLine().Trim().Trim('0');

int sdigit = int.Parse(Console.ReadLine());

if (sdigit == 0 || bigNumber.All(x => x == '0'))
{
    Console.WriteLine(0);
    return;
}

int[] product = new int[bigNumber.Length + 1];

for (int i = bigNumber.Length - 1; i >= 0; i--)
{
    int digit = bigNumber[i] - '0';

    int prod = digit * sdigit;

    product[i + 1] += prod;

    if (product[i + 1] >= 10)
    {
        product[i] += product[i + 1] / 10;
        product[i + 1] %= 10;
    }
}

string result = string.Concat(product).Trim('0');
Console.WriteLine(result);