﻿namespace _07._Theatre_Promotion
{

    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
           


            if (age >= 0 && age <= 18)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (day == "Weekend")
                {

                    Console.WriteLine("15$");
                }
                else if (day == "Holiday")
                {

                    Console.WriteLine("5$");
                }

            }
            else if (age > 18 && age <= 64)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (day == "Weekend")
                {

                    Console.WriteLine("20$");
                }
                else if (day == "Holiday")
                {

                    Console.WriteLine("12$");
                }

            }
            else if (age > 64 && age <= 122)
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (day == "Weekend")
                {

                    Console.WriteLine("15$");
                }
                else if (day == "Holiday")
                {

                    Console.WriteLine("10$");
                }

            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}