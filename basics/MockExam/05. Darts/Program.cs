namespace _05._Darts
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string cmd;

            int counter = 301;
            int successfulShots = 0;
            int failedShots = 0;
            //while ((cmd = Console.ReadLine()) != "Retire")
            //{
            //    int points = int.Parse(Console.ReadLine());

            //    if (cmd=="Single")
            //    {
            //        counter -= points;
            //    }

            //}
            while (counter != 0)
            {
                cmd = Console.ReadLine();

                if (cmd == "Retire")
                {
                    break;
                }
                int points = int.Parse(Console.ReadLine());

                if (cmd == "Single")
                {
                    if (points <= counter)
                    {
                        counter -= points;
                        successfulShots++;
                    }
                    else
                    {
                        failedShots++;
                    }

                }
                else if (cmd == "Double")
                {

                    if (points * 2 <= counter)
                    {
                        counter -= points * 2;
                        successfulShots++;
                    }
                    else
                    {
                        failedShots++;
                    }

                }
                else if (cmd == "Triple")
                {
                    if (points * 3 <= counter)
                    {
                        counter -= points * 3;
                        successfulShots++;
                    }
                    else
                    {
                        failedShots++;
                    }

                }

            }

            if (counter==0)
            {
                Console.WriteLine($"{name} won the leg with {successfulShots} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {failedShots} unsuccessful shots.");
            }

        }
    }
}