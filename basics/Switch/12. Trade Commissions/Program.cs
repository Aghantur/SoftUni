namespace _12._Trade_Commissions
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sellings = double.Parse(Console.ReadLine());

            double price = 0;

            
            switch (town)
            {
                case "Sofia":
                case "Varna":
                case "Plovdiv":

                    if (sellings < 0)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }

            if (town == "Sofia")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    price = sellings * 0.05;
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    price = sellings * 0.07;

                }

                else if (sellings > 1000 && sellings <= 10000)
                {
                    price = sellings * 0.08;

                }
                else if (sellings > 10000)
                {
                    price = sellings * 0.12;

                }
            }
            else if (town == "Varna")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    price = sellings * 0.045;
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    price = sellings * 0.075;

                }

                else if (sellings > 1000 && sellings <= 10000)
                {
                    price = sellings * 0.1;

                }
                else if (sellings > 10000)
                {
                    price = sellings * 0.13;

                }
            }
            else if (town == "Plovdiv")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    price = sellings * 0.055;
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    price = sellings * 0.08;

                }

                else if (sellings > 1000 && sellings <= 10000)
                {
                    price = sellings * 0.12;

                }
                else if (sellings > 10000)
                {
                    price = sellings * 0.145;

                }
            }

            Console.WriteLine($"{price:f2}");


        }
    }
}