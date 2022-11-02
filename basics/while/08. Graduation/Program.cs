namespace _08._Graduation
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int klas = 1;

            double allGrades = 0;

            int badGrades = 0;

            while (klas<=12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade>=4)
                {
                    klas++;
                    allGrades+=currentGrade;
                }
                else
                {
                    badGrades++;
                    if (badGrades>1)
                    {

                        Console.WriteLine($"{name} has been excluded at {klas} grade");
                        return;
                    }
                }

            }
            double average = allGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");



        }
    }
}