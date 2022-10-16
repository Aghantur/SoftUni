namespace _05._Journey
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string camp = "";
            double totalPrice = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    totalPrice = budget * 0.3;
                    camp = "Camp";
                }
                else
                {
                    totalPrice = budget * 0.7;
                    camp = "Hotel";
                }
            }

            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    totalPrice =  budget * 0.4;
                    camp = "Camp";
                }
                else
                {
                    totalPrice =  budget * 0.8;
                    camp = "Hotel";
                }

            }
            else if (budget > 1000)
            {
                destination = "Europe";
                totalPrice =  budget * 0.9;
                camp = "Hotel";

            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{camp} - {totalPrice:f2}");


        }
    }
}