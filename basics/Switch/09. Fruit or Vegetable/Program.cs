﻿namespace _09._Fruit_or_Vegetable
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string fwfw = Console.ReadLine();

            switch (fwfw)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":

                    Console.WriteLine("fruit");
                    break;


                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":

                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}