namespace _04._Train_The_Trainers
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double totalAverage = 0;
            double cntTotalAveragePresentation = 0;
            int cntPresentation = 0;
            string marks;
            while (presentation != "Finish")
            {

                double averagePresentation = 0;
                marks = presentation;
                for (int i = 0; i < n; i++)
                {

                    averagePresentation += double.Parse(Console.ReadLine());

                }
                cntTotalAveragePresentation += averagePresentation / n;//suma ot srednite ocenki 

                Console.WriteLine($"{marks} - {averagePresentation / n:f2}.");
                cntPresentation++;// broi prezentacii
                presentation = Console.ReadLine();
            }

            totalAverage = cntTotalAveragePresentation / cntPresentation; // sredna ocenka ot vsichki prezentacii

            Console.WriteLine($"Student's final assessment is {totalAverage:f2}.");


        }
    }
}