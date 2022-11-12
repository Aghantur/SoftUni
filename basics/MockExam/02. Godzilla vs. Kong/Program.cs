namespace _02._Godzilla_vs._Kong
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int timePerScene = int.Parse(Console.ReadLine());
            double fwfw = time * 0.15;
            double totalTime =  scenes * timePerScene;

            double finalTime = fwfw + totalTime;

            if (time >= finalTime)
            {

                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(time-finalTime)} minutes left!");
                
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(finalTime-time)} minutes.");
            }


        }
    }
}