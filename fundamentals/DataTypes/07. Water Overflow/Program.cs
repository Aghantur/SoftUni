namespace _07._Water_Overflow
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int iteration = int.Parse(Console.ReadLine());


            int capacity = 255;
            int sum = 0;

            for (int i = 0; i < iteration; i++)
            {
                int water = int.Parse(Console.ReadLine());

                if (water <= capacity - sum)
                {
                    sum += water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sum);
        }
    }
}