namespace _01._Birthday_Party
{

    using System;
    internal class Program
    {

        static void Main(string[] args)
        {
            double totalMoney = double.Parse(Console.ReadLine());

            double cake = totalMoney * 0.2;
            double drinks = cake - (cake * 0.45);
            double anime = totalMoney / 3;

            double neededMoney = cake + drinks + anime + totalMoney;

            Console.WriteLine(neededMoney);

        }
    }
}