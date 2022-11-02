namespace _04._Walking
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {


            int stepCnt = 0;

            while (stepCnt < 10000)
            {
                string steps = Console.ReadLine();

                if (steps  == "Going home")
                {
                    steps = Console.ReadLine();
                    stepCnt += int.Parse(steps);

                    if (stepCnt>=10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepCnt - 10000} steps over the goal!");
                        return;
                    }
                    Console.WriteLine($"{Math.Abs(10000 - stepCnt)} more steps to reach goal.");
                   return;


                }
                stepCnt += int.Parse(steps);
               
            }

            if (stepCnt >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepCnt - 10000} steps over the goal!");
               
            }

        }
    }
}