namespace _08._Lunch_Break
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double eatTime = Math.Ceiling(breakTime / 8.0);
            double pochivka = Math.Ceiling(breakTime / 4.0);
            double leftTime = breakTime - eatTime - pochivka;

            if (leftTime>=episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {leftTime-episodeTime} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {episodeTime-leftTime} more minutes.");
            }

        }
    }
}