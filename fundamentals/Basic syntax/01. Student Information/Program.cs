namespace _01._Student_Information
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int agae = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {agae}, Grade: {grade:f2}");

        }
    }
}