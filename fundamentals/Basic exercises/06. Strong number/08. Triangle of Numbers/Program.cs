﻿namespace _08._Triangle_of_Numbers
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i.ToString()} ");
                }
                Console.WriteLine();
            }


        }
    }
}