namespace _05._Godzilla_vs._Kong
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            if (people>150)
            {
                costumePrice -= 0.1 * costumePrice;
            }
            double decorPrice = budget * 0.1;
            double priceTotal = (people * costumePrice) + decorPrice;


            if (budget >= priceTotal)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-priceTotal:F2} leva left.");
            }
            else 
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {priceTotal-budget:F2} leva more.");
            }

        }
    }
}