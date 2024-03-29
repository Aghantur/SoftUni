﻿namespace _02._Equal_Sums_Even_Odd_Position
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                string currNum = i.ToString();

                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currNum.Length; j++)
                {
                    int currDigit = int.Parse(currNum[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}