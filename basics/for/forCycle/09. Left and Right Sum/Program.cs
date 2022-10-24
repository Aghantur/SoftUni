namespace _09._Left_and_Right_Sum
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;

            for (int i = 0; i < n; i++)
            {

                int num = int.Parse(Console.ReadLine());

                left +=num;
            }

            for (int i = 0; i < n; i++)
            {

                int num = int.Parse(Console.ReadLine());

                right +=num;
            }
            if (left==right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(left - right)}");
            }
        }
    }
}