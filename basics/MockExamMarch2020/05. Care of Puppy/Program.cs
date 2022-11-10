namespace _05._Care_of_Puppy
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine()) * 1000; //total food
            int foodCnt = 0; // eaten total food

            int totalFood = food;//left food
            string command;

            while ((command = Console.ReadLine()) != "Adopted")
            {
                int eastenFood = int.Parse(command); // eaten food per day
                foodCnt += eastenFood;

                totalFood -= eastenFood;
                
            }

            if (foodCnt <= food)
            {

                Console.WriteLine($"Food is enough! Leftovers: {totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodCnt - food} grams more.");
            }


        }
    }
}