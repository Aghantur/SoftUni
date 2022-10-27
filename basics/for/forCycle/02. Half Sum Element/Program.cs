namespace _02._Half_Sum_Element
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum+=num;


                if (num > max)
                {
                    max = num;
                }


            }

            sum -= max;

            if (sum==max)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max)}");
            }

        }
    }
}