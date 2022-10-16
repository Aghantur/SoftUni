namespace _03._New_House
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (flower=="Roses")
            {
                totalPrice = number * 5;

                if (number>80)
                {
                    totalPrice -= totalPrice * 0.1;
                }
            }


            else if (flower == "Dahlias")
            {
                totalPrice = number * 3.8;

                if (number > 90)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }

            else if (flower == "Tulips")
            {
                totalPrice = number * 2.8;

                if (number > 80)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }


            else if (flower == "Narcissus")
            {
                totalPrice = number * 3;

                if (number < 120)
                {
                    totalPrice += totalPrice * 0.15;
                }
            }

            else if (flower == "Gladiolus")
            {
                totalPrice = number * 2.5;

                if (number < 80)
                {
                    totalPrice += totalPrice * 0.2;
                }
            }
            if (budget>=totalPrice)
            {

                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {number} {flower} and {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyMore = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyMore:F2} leva more.");
            }
        }
    }
}