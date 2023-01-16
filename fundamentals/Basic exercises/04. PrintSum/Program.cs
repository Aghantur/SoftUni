namespace _04._PrintSum
{
    using System;
    internal class Program
    {

        static void Main(string[] args)
        {
            

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = m; i <= n; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}