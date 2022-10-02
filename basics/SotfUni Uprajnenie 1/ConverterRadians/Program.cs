namespace ConverterRadians
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            double radians = double.Parse(Console.ReadLine());
            double angleDegree = (radians*180)/Math.PI;
            Console.WriteLine(angleDegree);


        }
    }
}