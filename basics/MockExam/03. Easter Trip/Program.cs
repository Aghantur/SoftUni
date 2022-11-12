namespace _03._Easter_Trip
{


    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


            double price = 0;


            switch (destination)
            {

                case "France":
                    if (date == "21-23")
                    {
                        price = 30;
                    }
                    else if (date == "24-27")
                    {
                        price = 35;
                    }
                    else if (date == "28-31")
                    {
                        price = 40;
                    }

                    break;
                case "Italy":
                    if (date == "21-23")
                    {
                        price = 28;
                    }
                    else if (date == "24-27")
                    {
                        price = 32;
                    }
                    else if (date == "28-31")
                    {
                        price = 39;
                    }


                    break;
                case "Germany":
                    if (date == "21-23")
                    {
                        price = 32;
                    }
                    else if (date == "24-27")
                    {
                        price = 37;
                    }
                    else if (date == "28-31")
                    {
                        price = 43;
                    }


                    break;
                default:
                    break;
            }

            double totalPrice = price * nights;
            Console.WriteLine($"Easter trip to {destination} : {totalPrice:f2} leva.");

        }
    }
}