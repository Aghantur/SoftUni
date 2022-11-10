namespace _02._Cat_Walking
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int mins = int.Parse(Console.ReadLine());
            int walks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            double total = mins* walks*5;
            if (total<calories/2)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {total}.");
            }
            else
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {total}.");
            }



        }
    }
}