namespace _06._Strong_number
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int copy = n;

            int sum = 0;

            while (copy > 0)
            {
                int digit = copy % 10;
                copy = copy / 10;

                int factorial = 1;

                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }

            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}