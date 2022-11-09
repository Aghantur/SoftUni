namespace _04._Sum_of_Two_Numbers
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            bool isFound = false;    
            for (int i = n; i <= x; i++)
            {
                for (int j = n; j <= x; j++)
                {

                    count++;
                    if (i+j == y)
                    {

                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {y})");
                        isFound = true; 
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }

            }
            if (!isFound)
            {

                Console.WriteLine($"{count} combinations - neither equals {y}");
            }


        }
    }
}