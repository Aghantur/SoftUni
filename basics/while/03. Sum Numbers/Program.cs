﻿namespace _03._Sum_Numbers
{
    using System;
    internal class Program

    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum < num)
            {

                int num2 = int.Parse(Console.ReadLine());
                sum += num2;
            }

            Console.WriteLine(sum);

        }
    }
}