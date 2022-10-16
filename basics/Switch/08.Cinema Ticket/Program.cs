namespace _08.Cinema_Ticket
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int price = 0;

            switch (day)
            {

                case "Monday":
                case "Tuesday":
                case "Friday":
                    price = 12;
                    Console.WriteLine(price);
                    break;
                case "Wednesday":
                case "Thursday":
                    price = 14;
                    Console.WriteLine(price);
                    break;
                case "Saturday":
                case "Sunday":
                    price = 16;
                    Console.WriteLine(price);
                    break;
                    

                default:
                    break;
            }



        }
    }
}