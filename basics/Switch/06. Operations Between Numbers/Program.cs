namespace _06._Operations_Between_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();


            if (b == 0 && (symbol=="/" || symbol=="%"))
            {
                Console.WriteLine($"Cannot divide {a} by zero");
            }
            else if (symbol=="/")
            {

                Console.WriteLine($"{a} / {b} = {(a / b):F2}");
            }
            else if (symbol=="%")
            {

                Console.WriteLine($"{a} % {b} = {a % b}");
            }  
            

            if (symbol == "*")
            {
                if ((a * b) % 2 == 0)
                {
                    Console.WriteLine($"{a} * {b} = {(a * b)} - even");
                }
                else
                {
                    Console.WriteLine($"{a} * {b} = {(a * b)} - odd");
                }
            }
            else if (symbol == "+")
            {
                if ((a + b) % 2 == 0)
                {
                    Console.WriteLine($"{a} + {b} = {(a + b)} - even");
                }
                else
                {
                    Console.WriteLine($"{a} + {b} = {(a + b)} - odd");
                }
            }
            else if (symbol == "-")
            {
                if ((a - b) % 2 == 0)
                {
                    Console.WriteLine($"{a} - {b} = {(a - b)} - even");
                }
                else
                {
                    Console.WriteLine($"{a} - {b} = {(a - b)} - odd");
                }
            }

        }
    }
}