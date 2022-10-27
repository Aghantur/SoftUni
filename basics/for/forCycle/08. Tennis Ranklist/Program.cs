namespace _08._Tennis_Ranklist
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int tours = int.Parse(Console.ReadLine());
            int pp = int.Parse(Console.ReadLine());

            double totalPoints = pp;
            double won = 0;

            for (int i = 0; i < tours; i++)
            {
                string participation = Console.ReadLine();

                if (participation=="W")
                {
                    totalPoints += 2000;
                }
                else if (participation=="F")
                {
                    totalPoints += 1200;
                }
                else if (participation=="SF")
                {
                    totalPoints += 720;
                }

                
                if (participation=="W")
                {
                    won++;
                }
            }

            double pWins = won / tours * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor((totalPoints-pp)/tours)}");

            Console.WriteLine($"{pWins:f2}%");



        }
    }
}