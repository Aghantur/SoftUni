using System.Numerics;

int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

//int factorial = 1;
//for (int i = 1; i < first; i++)
//{
//    factorial *= i;
//}

Console.WriteLine("{0:f2}",(double)Factorial(first) / Factorial(second));

long Factorial(int number)
{
    if (number < 1)
    {
        return 1;
    }

    return number * Factorial(number - 1);
}