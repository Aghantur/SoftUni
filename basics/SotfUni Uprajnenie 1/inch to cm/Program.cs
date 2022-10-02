namespace inch_to_cm
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = 2.54;
            double c = a * b;
            Console.WriteLine(c);
        }
    }
}