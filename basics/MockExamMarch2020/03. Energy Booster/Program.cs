namespace _03._Energy_Booster
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string package = Console.ReadLine();
            int cnt = int.Parse(Console.ReadLine());

            double price = 0;

            if (fruit == "Watermelon")
            {
                if (package == "small")
                {

                    price = 56 * 2 * cnt;
                }
                else if (package == "big")
                {
                    price = 28.7 * cnt * 5;
                }

            }
            else if (fruit == "Mango")
            {
                if (package == "small")
                {

                    price = 36.66 * 2 * cnt;
                }
                else if (package == "big")
                {
                    price = 19.6 * cnt * 5;
                }

            }
            else if (fruit == "Pineapple")
            {
                if (package == "small")
                {

                    price = 42.1 * 2 * cnt;
                }
                else if (package == "big")
                {
                    price = 24.8 * cnt * 5;
                }

            }
            else if (fruit == "Raspberry")
            {
                if (package == "small")
                {

                    price = 20 * 2 * cnt;
                }
                else if (package == "big")
                {
                    price = 15.2 * cnt * 5;
                }

            }

            if (price > 1000)
            {
                price -= price / 2;
                Console.WriteLine($"{price:f2} lv.");
            }
            else if (price >= 400 && price <= 1000)
            {
                price -= price * 0.15;
                Console.WriteLine($"{price:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{price:f2} lv.");
            }



        }
    }
}