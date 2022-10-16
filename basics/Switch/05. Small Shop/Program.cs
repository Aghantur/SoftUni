namespace _05._Small_Shop
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double price = 0;




            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    price = count * 0.5;
                }
                else if (product == "water")
                {
                    price = count * 0.8;
                }
                else if (product == "beer")
                {
                    price = count * 1.2;
                }
                else if (product == "sweets")
                {
                    price = count * 1.45;
                }
                else if (product == "peanuts")
                {
                    price = count * 1.6;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = count * 0.4;
                }
                else if (product == "water")
                {
                    price = count * 0.7;
                }
                else if (product == "beer")
                {
                    price = count * 1.15;
                }
                else if (product == "sweets")
                {
                    price = count * 1.3;
                }
                else if (product == "peanuts")
                {
                    price = count * 1.5;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    price = count * 0.45;
                }
                else if (product == "water")
                {
                    price = count * 0.7;
                }
                else if (product == "beer")
                {
                    price = count * 1.1;
                }
                else if (product == "sweets")
                {
                    price = count * 1.35;
                }
                else if (product == "peanuts")
                {
                    price = count * 1.55;
                }
            }
            Console.WriteLine(price);

        }
    }
}