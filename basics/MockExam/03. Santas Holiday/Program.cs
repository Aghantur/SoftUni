namespace _03._Santas_Holiday
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string type = Console.ReadLine();
            string ocenka = Console.ReadLine();

            double price = 0;

            if (type == "room for one person")
            {

                price = days * 18;
                if (ocenka == "positive")
                {
                    price += price * 0.25;
                }
                else if (ocenka == "negative")
                {
                    price -= price * 0.1;
                }

            }
            else if (type == "apartment")
            {
                if (days < 10)
                {
                    price = days * 25;
                    price -= price * 0.3;
                }
                else if (days >= 10 && days <= 15)
                {

                    price = days * 25;
                    price -= price * 0.35;
                }
                else if (days > 15)
                {

                    price = days * 25;
                    price -= price / 2;
                }
                if (ocenka == "positive")
                {
                    price += price * 0.25;
                }
                else if (ocenka == "negative")
                {
                    price -= price * 0.1;
                }
            }
            else if (type == "president apartment")
            {
                if (days < 10)
                {
                    price = days * 35;
                    price -= price * 0.1;
                }
                else if (days >= 10 && days <= 15)
                {

                    price = days * 35;
                    price -= price * 0.15;
                }
                else if (days > 15)
                {

                    price = days * 35;
                    price -= price * 0.2;
                }
                if (ocenka == "positive")
                {
                    price += price * 0.25;
                }
                else if (ocenka == "negative")
                {
                    price -= price * 0.1;
                }
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}