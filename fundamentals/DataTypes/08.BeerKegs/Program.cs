namespace _08.BeerKegs
{
    using System;


    internal class Program
    {
        static void Main(string[] args)
        {

            int numberKegs = int.Parse(Console.ReadLine());

            string bestModel = "";
            double biggestVolume = 0;

            for (int i = 0; i < numberKegs; i++)
            {
                string model= Console.ReadLine();    
                double r =double.Parse(Console.ReadLine());

                int height=int.Parse(Console.ReadLine());

                double volume = Math.PI*r*r*height;

                if (volume>biggestVolume)
                {
                    biggestVolume = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}