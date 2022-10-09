namespace _04._Toy_Shop
{


    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            double price = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());  
            int minions = int.Parse(Console.ReadLine());
            int trucks =  int.Parse(Console.ReadLine());

            int toyCount = puzzleCount + dolls + bears + minions + trucks;

            double sum = (puzzleCount * 2.6) + (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);

            if (toyCount>=50)
            {

                sum -= sum * 0.25;
            }
            sum -= sum * 0.1;

            if (sum>=price)
            {

                double moneyLeft = sum - price;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                double moneyNeeded = price - sum;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }

        }
    }
}