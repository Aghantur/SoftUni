namespace _05._Account_Balance
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);

                if (amount >= 0)
                {
                    sum += amount;
                    Console.WriteLine($"Increase: {amount:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Total: {sum:F2}");


        }
    }
}