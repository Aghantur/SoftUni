namespace _1.Oscars
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int naem = int.Parse(Console.ReadLine());

            double statues = naem - (naem * 0.3);
            double ketering = statues - statues * 0.15;
            double sound = ketering / 2;

            double total = naem + statues+ketering+sound;

            Console.WriteLine($"{total:F2}");
        }
    }
}