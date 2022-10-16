namespace _04._Fishing_Boat
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (season == "Spring")
            {
                totalPrice = 3000;
            }
            else if (season == "Winter")
            {
                totalPrice = 2600;
            }
            else
            {
                totalPrice = 4200;
            }

            if (fisherman <= 6)
            {
                totalPrice -= totalPrice * 0.1;
            }

            else if (fisherman >= 7 && fisherman <= 11)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (fisherman >= 12)
            {
                totalPrice -= totalPrice * 0.25;
            }

            if (season != "Autumn" && fisherman % 2 == 0)
            {
                totalPrice -= totalPrice * 0.05;
            }
            double priceLeft = budget - totalPrice;
            if (priceLeft >= 0)
            {
                Console.WriteLine($"Yes! You have {priceLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(priceLeft):f2} leva.");
            }
        }
    }
}