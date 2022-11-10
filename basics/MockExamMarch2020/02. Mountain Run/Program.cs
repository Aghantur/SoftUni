namespace _02._Mountain_Run
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double sec = double.Parse(Console.ReadLine());
            double meter = double.Parse(Console.ReadLine());    
            double mPerSec=double.Parse(Console.ReadLine());

            double total = mPerSec*meter;

            double newTotal = total+(Math.Floor(meter / 50) * 30);

            if (newTotal<sec)
            {
                Console.WriteLine($" Yes! The new record is {newTotal:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {Math.Abs(sec-newTotal):f2} seconds slower.");
            }


        }
    }
}