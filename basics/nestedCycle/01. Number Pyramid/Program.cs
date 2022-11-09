namespace _01._Number_Pyramid
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 1;
            bool isReady = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    if (count > n)
                    {

                        isReady = true;
                        break;
                    }

                    Console.Write($"{count} ");
                    count++;
                }

                if (isReady)
                {
                    break;
                }

                Console.WriteLine();
            }


        }
    }
}