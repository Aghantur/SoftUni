namespace _07._Hotel_Room
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double appPrice = 0;
            double studioPrice = 0;

            if (month=="May" || month=="October")
            {
                studioPrice = nightsCount * 50;
                appPrice=nightsCount * 65;
                if (nightsCount>14)
                {
                    studioPrice -= studioPrice * 0.3;
                    
                }
                else if(nightsCount>7)
                {
                    studioPrice -= studioPrice * 0.05;
                }

            }
            else if (month=="June"||month=="September")
            {
                studioPrice = nightsCount * 75.2;
                appPrice = nightsCount * 68.70;

                if (nightsCount>14)
                {
                    studioPrice -= studioPrice * 0.2;
                }
            }
            else if (month=="July"||month=="August")
            {
                studioPrice = nightsCount * 76;
                appPrice = nightsCount * 77;
            }

            if (nightsCount>14)
            {
                appPrice -= appPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {appPrice:F2} lv.");
            
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");


        }
    }
}