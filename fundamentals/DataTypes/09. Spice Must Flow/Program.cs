namespace _09._Spice_Must_Flow
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int sum = 0;
            int spicePerDay = 0;

            while (yield >= 100)
            {

                days++;
                spicePerDay = yield - 26;

                sum += spicePerDay;
                yield -= 10;

            }
            if (days>0)
            {
                sum -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}