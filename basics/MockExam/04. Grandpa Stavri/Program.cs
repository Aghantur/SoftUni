namespace _04._Grandpa_Stavri
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalRakia = 0;
            double totalGradusFinal = 0;
            double gradus1 = 0;

            for (int i = 0; i < n; i++)
            {

                double rakia = double.Parse(Console.ReadLine());
                double gradus = double.Parse(Console.ReadLine());

                totalRakia += rakia;
                double totalGradus = rakia * gradus;

                gradus1 += totalGradus;

            }
            double average = gradus1/totalRakia;

            if (average<38)
            {

                Console.WriteLine($"Liter: {totalRakia:f2}");
                Console.WriteLine($"Degrees: {average:f2}");
                Console.WriteLine("Not good, you should baking!");
            }
            else if (average>42)
            {

                Console.WriteLine($"Liter: {totalRakia:f2}");
                Console.WriteLine($"Degrees: {average:f2}");
                Console.WriteLine("Dilution with distilled water!");
            }
            else
            {
                Console.WriteLine($"Liter: {totalRakia:f2}");
                Console.WriteLine($"Degrees: {average:f2}");
                Console.WriteLine("Super!");
            }

        }
    }
}