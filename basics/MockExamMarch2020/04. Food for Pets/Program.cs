namespace _04._Food_for_Pets
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double biscuitCnt = 0;
            double dogFoodTotal = 0;
            double catFoodTotal = 0;

            for (int i = 1; i <= days; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    double biscuits = (dogFood + catFood) * 0.1;
                    biscuitCnt += biscuits;
                }

                dogFoodTotal += dogFood;
                catFoodTotal += catFood;

            }

            double eatenFood = dogFoodTotal + catFoodTotal;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuitCnt)}gr.");
            Console.WriteLine($"{eatenFood / food * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogFoodTotal / eatenFood * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{catFoodTotal / eatenFood * 100:f2}% eaten from the cat.");


        }
    }
}