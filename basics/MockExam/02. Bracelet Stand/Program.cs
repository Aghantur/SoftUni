namespace _02._Bracelet_Stand
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double jobni = double.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double razhodi = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double jobniSpesteni = jobni * 5;
            double spesteni = moneyPerDay * 5;
            double total = jobniSpesteni + spesteni-razhodi;

            if (total>=giftPrice)
            {
                Console.WriteLine($"Profit: {total:F2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {giftPrice-total:f2} BGN.");
            }


        }
    }
}