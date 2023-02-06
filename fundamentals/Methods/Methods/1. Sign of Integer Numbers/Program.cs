


static void Positive(int n)
{

    if (n > 0)
    {

        Console.WriteLine($"The number {n} is positive.");
    }
    else if (n<0)
    {

        Console.WriteLine($"The number {n} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {n} is zero.");
    }

}

int num = int.Parse(Console.ReadLine());

Positive(num);