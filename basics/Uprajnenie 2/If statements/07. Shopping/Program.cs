namespace _07._Shopping
{

    using System;
    using System.Reflection.PortableExecutable;

    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int video = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());


            double videoPrice = video * 250;
            double processorPrice = (videoPrice * 0.35)*processor;
            double ramPrice = (videoPrice * 0.1)*ram;

            double totalSum = videoPrice + processorPrice + ramPrice;

            if (video>processor)
            {
                totalSum -= totalSum*0.15;
            }

            if (budget>=totalSum)
            {
                Console.WriteLine($"You have {budget-totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum-budget:F2} leva more!");
            }


        }
    }
}