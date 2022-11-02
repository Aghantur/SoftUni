namespace _02._Exam_Preparation
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int badMarkcnt = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedProblemsCnt = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;


            while (failedTimes < badMarkcnt)
            {
                string zadacha = Console.ReadLine();

                if ("Enough" == zadacha)
                {
                    isFailed = false;
                    break;
                }

                int ocenka = int.Parse(Console.ReadLine());

                if (ocenka <= 4)
                {
                    failedTimes++;
                }

                gradesSum += ocenka;
                solvedProblemsCnt++;
                lastProblem = zadacha;

            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badMarkcnt} poor grades.");

            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum/solvedProblemsCnt:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCnt}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }



        }
    }
}