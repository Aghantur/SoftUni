namespace _06._Max_Number
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int max = int.MinValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number > max)
                {
                    max = number;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine(max);
        }
    }
}