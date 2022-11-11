namespace _03._Aluminum_Joinery
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int dograma = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dostavka = Console.ReadLine();

            double price = 0;
            if (dograma<10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            if (type == "90X130")
            {
                price = 110*dograma;
                if (dograma > 60)
                {
                    price -= price * 0.08;

                }
                else if (dograma > 30)
                {

                    price -= price * 0.05;
                }
            }
            else if (type == "100X150")
            {
                price = 140*dograma;
                if (dograma > 80)
                {
                    price -= price * 0.1;

                }
                else if (dograma > 40)
                {

                    price -= price * 0.06;
                }
            }
            else if (type == "130X180")
            {
                price = 190 * dograma;
                if (dograma > 50)
                {
                    price -= price * 0.12;

                }
                else if (dograma > 20)
                {

                    price -= price * 0.07;
                }
            }
            else if (type == "200X300")
            {
                price = 250 * dograma;
                if (dograma > 50)
                {
                    price -= price * 0.14;

                }
                else if (dograma > 25)
                {

                    price -= price * 0.09;
                }
            }

            if (dostavka=="With delivery")
            {
                price += 60;
            }
            if (dograma>99)
            {
                price -= price * 0.04;
            }

            Console.WriteLine($"{price:f2} BGN");


        }
    }
}