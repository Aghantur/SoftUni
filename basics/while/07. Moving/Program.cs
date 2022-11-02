namespace _07._Moving
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int totalArea = x * y * z;

            string command;
            int takenArea=0;

            while ((command = Console.ReadLine()) != "Done")
            {
               
                takenArea += int.Parse(command);

                if (takenArea > totalArea)
                {
                    Console.WriteLine($"No more free space! You need {takenArea - totalArea} Cubic meters more.");
                    return;
                }

            }

            Console.WriteLine($"{totalArea - takenArea} Cubic meters left.");

        }
    }
}