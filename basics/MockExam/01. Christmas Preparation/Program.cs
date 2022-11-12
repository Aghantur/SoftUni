namespace _01._Christmas_Preparation
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int paper = int.Parse(Console.ReadLine());
            int plat = int.Parse(Console.ReadLine());
            double lepilo = double.Parse(Console.ReadLine());
            int percentNamalenie = int.Parse(Console.ReadLine());

            double paperValue = paper * 5.8;
            double platValue = plat * 7.2;
            double lepiloValue = lepilo * 1.2;

            double total = paperValue + platValue + lepiloValue;
            double final =total- total*percentNamalenie/100;

            Console.WriteLine($"{final:f3}");


        }
    }
}