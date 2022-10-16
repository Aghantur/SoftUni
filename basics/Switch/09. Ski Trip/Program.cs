﻿namespace _09._Ski_Trip
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            string roomType=Console.ReadLine();
            string feedback = Console.ReadLine();

            double totalPrice = 0;
            if (roomType=="room for one person")
            {
                totalPrice = (daysCount - 1) * 18;
            }
            else if (roomType=="apartment")
            {
                totalPrice = (daysCount - 1) * 25;

                if (daysCount<10)
                {
                    totalPrice -= totalPrice * 0.3;
                }
                else if (daysCount>=10 && daysCount<=15)
                {
                    totalPrice -= totalPrice * 0.35;
                }
                else
                {
                    totalPrice -= totalPrice * 0.5;
                }
            }
            else if (roomType=="president apartment")
            {
                totalPrice = (daysCount - 1) * 35;

                if (daysCount<10)
                {
                    totalPrice -= totalPrice * 0.1;
                }
                else if (daysCount>=10&&daysCount<=15)
                {
                    totalPrice -= totalPrice * 0.15;
                }
                else
                {
                    totalPrice -= totalPrice * 0.2;
                }
            }
            if (feedback=="positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
            {
                totalPrice -= totalPrice * 0.1;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}