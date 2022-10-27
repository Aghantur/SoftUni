namespace _07._Trekking_Mania
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int totalPpl = 0;
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int g5 = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());

                totalPpl += people;

                if (people <= 5)
                {
                    g1+=people;
                }
                else if (people >= 6 && people < 13)
                {
                    g2+=people;

                }
                else if (people >= 13 && people < 26)
                {
                    g3+=people;

                }
                else if (people >= 26 && people < 41)
                {
                    g4+=people;

                }else 
                {
                    g5+=people;

                }
            }

            double p1 = (double)g1 / totalPpl * 100;
            double p2 = (double)g2 / totalPpl * 100;
            double p3 = (double)g3 / totalPpl * 100;
            double p4 = (double)g4 / totalPpl * 100;
            double p5 = (double)g5 / totalPpl * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}