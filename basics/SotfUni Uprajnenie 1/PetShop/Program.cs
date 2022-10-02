namespace PetShop
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());


            double dogPrice = dogsFood * 2.5;
            double catPrice = catFood * 4;


            Console.WriteLine((dogPrice+catPrice)+" lv.");


        }
    }
}