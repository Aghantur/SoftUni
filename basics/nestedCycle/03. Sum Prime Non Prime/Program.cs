namespace _03._Sum_Prime_Non_Prime
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string command;
            int Prime = 0;
            int nonPrime = 0;


            while ((command = Console.ReadLine()) != "stop")
            {
                int currNumber = int.Parse(command);

                if (currNumber < 0)
                {
                    Console.WriteLine($"Number is negative.");
                    continue;
                }
                else if (currNumber == 0 || currNumber == 1)
                {
                    nonPrime += currNumber;
                    continue;
                }

                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(currNumber); i++)
                {
                    if (currNumber%i==0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Prime += currNumber;
                }
                else 
                {
                    nonPrime += currNumber;
                }

            }

            Console.WriteLine($"Sum of all prime numbers is: {Prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");

        }
    }
}