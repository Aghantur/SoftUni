namespace _05._Coins
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int coin = 0;
            money = Math.Round(money * 100);

            while (money > 0)
            {
                if (money >= 200)
                {
                    coin++;
                    money = money - 200;
                }
                else if (money >= 100)
                {
                    coin++;
                    money = money - 100;
                }
                else if (money >= 50)
                {
                    coin++;
                    money = money - 50;
                }
                else if (money >= 20)
                {
                    coin++;
                    money = money - 20;
                }
                else if (money >= 10)
                {
                    coin++;
                    money = money - 10;
                }
                else if (money >= 5)
                {
                    coin++;
                    money = money - 5;
                }
                else if (money >= 2)
                {
                    coin++;
                    money = money - 2;
                }
                else if (money >= 1)
                {
                    coin++;
                    money = money - 1;
                }
            }

            Console.WriteLine(coin);
        }
    }
}