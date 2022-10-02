namespace FoodDeliveryServices
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        { 

            int chicken = int.Parse(Console.ReadLine());
            int fish =  int.Parse(Console.ReadLine());
            int vegie =  int.Parse(Console.ReadLine());

            double chickenPrice = chicken * 10.35;
            double fishPrice = fish * 12.4;
            double vegiePrice = vegie * 8.15;

            double sum = chickenPrice + fishPrice + vegiePrice;
            double desert = (sum * 0.2);

            double totalSum = 2.5 + sum + desert;
            Console.WriteLine(totalSum);



        }
    }
}