namespace _05._Best_Player
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            string cmd;
            int max = int.MinValue;
            string best = "";
            int goals = 0;

            while ((cmd = Console.ReadLine()) != "END")
            {
                goals = int.Parse(Console.ReadLine());


                if (goals > max)
                {
                    max = goals;
                    best = cmd;
                }
                if (goals >= 10)
                {
                    break;
                }


            }
            if (goals >= 3)
            {
                Console.WriteLine($"{best} is the best player!");
                Console.WriteLine($"He has scored {max} goals and made a hat-trick !!!");

            }
            else
            {
                Console.WriteLine($"{best} is the best player!");
                Console.WriteLine($"He has scored {max} goals.");
            }


        }
    }
}