namespace _06._Cake
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int total = x * y;

            string command;

            while ((command = Console.ReadLine()) != "STOP")
            {
                int piecesTaken = int.Parse(command);

                total -= piecesTaken;

                if (total<0)
                {
                    break;
                }

            }

            if (total<0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(total)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{total} pieces are left.");
            }

        }
    }
}