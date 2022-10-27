namespace _04._Clever_Lily
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int totalMoney = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    totalMoney += toyPrice;
                }
                else
                {
                    int moneyGain = i / 2 * 10;

                    totalMoney+=moneyGain;
                    totalMoney -= 1;
                }


            }

            if (totalMoney>=washerPrice)
            {
                Console.WriteLine($"Yes! {totalMoney-washerPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washerPrice-totalMoney:F2}");
            }

        }
    }
}