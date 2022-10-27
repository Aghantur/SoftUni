namespace _06._Oscars
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string actor = Console.ReadLine();
            double pp = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double totalPoints = pp;

            for (int i = 0; i < judges; i++)
            {
                string nameJudge = Console.ReadLine();
                double pointsJudge = double.Parse(Console.ReadLine());
                int length = nameJudge.Length;

                totalPoints += (length * pointsJudge) / 2;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }
            }

            double diff = 1250.5 - totalPoints;
            Console.WriteLine($"Sorry, {actor} you need {diff:f1} more!");





        }
    }
}