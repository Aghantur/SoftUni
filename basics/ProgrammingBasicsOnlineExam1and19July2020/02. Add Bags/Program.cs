namespace _02._Add_Bags
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceAbove20 = double.Parse(Console.ReadLine());
            double teglo = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int luggage = int.Parse(Console.ReadLine());

            double counterBagaj = 0;

            if (teglo < 10)
            {
                counterBagaj += priceAbove20 * 0.2;
            }
            else if (teglo >= 10 && teglo <= 20)
            {

                counterBagaj += priceAbove20 / 2;
            }
            else
            {
                counterBagaj += priceAbove20;
            }

            if (days < 7)
            {
                counterBagaj += counterBagaj * 0.4;
            }
            else if (days >= 7 && days <= 30)
            {
                counterBagaj += counterBagaj * 0.15;

            }
            else
            {
                counterBagaj += counterBagaj * 0.1;
            }

            Console.WriteLine($"The total price of bags is: {counterBagaj*luggage:F2} lv. ");

        }
    }
}