namespace _03._Histogram
{

    using System;
    using System.Security;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            int d4 = 0;
            int d5 = 0;


            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 200)
                {
                    d1++;
                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    d2++;
                }
                else if (currentNum >= 400 && currentNum < 600)
                {
                    d3++;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    d4++;
                }
                else
                {
                    d5++;
                }


            }

            double p1 = ((double)d1 / n) * 100;
            double p2 = ((double)d2 / n) * 100;
            double p3 = ((double)d3 / n) * 100;
            double p4 = ((double)d4 / n) * 100;
            double p5 = ((double)d5 / n) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}