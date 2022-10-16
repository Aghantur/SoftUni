namespace _01._Cinema
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            double totalPrice = 0;

            if (name =="Premiere")
            {
                totalPrice = r * c * 12;
            }
            else if (name == "Normal")
            {
                totalPrice = r * c * 7.5;
            } else if (name == "Discount")
            {
                totalPrice = r * c * 5;
            }

            Console.WriteLine($"{totalPrice} leva");
        }
    }
}