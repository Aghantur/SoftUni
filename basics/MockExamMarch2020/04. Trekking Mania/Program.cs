namespace _04._Trekking_Mania
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int g5 = 0;

            int totalPpl = 0;

            for (int i = 0; i < groups; i++)
            {
                int ppl = int.Parse(Console.ReadLine());
                totalPpl += ppl;

                if (ppl <= 5)
                {
                    g1 += ppl;
                }
                else if (ppl >= 6 && ppl <= 12)
                {
                    g2 += ppl;
                }
                else if (ppl >= 13 && ppl <= 25)
                {
                    g3 += ppl;
                }
                else if (ppl >= 26 && ppl <= 40)
                {
                    g4 += ppl;
                }
                else if (ppl >= 41)
                {
                    g5 += ppl;
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