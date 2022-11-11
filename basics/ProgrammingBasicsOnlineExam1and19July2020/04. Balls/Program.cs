namespace _04._Balls
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double red = 0;
            double other = 0;
            double orange = 0;
            double yellow = 0;
            double white = 0;
            double black = 0;
            double total = 0;

            for (int i = 0; i < n; i++)
            {
                string type = Console.ReadLine();
                if (type == "red")
                {
                    red++;
                    total += 5;
                }
                else if (type == "orange")
                {
                    orange++;
                    total += 10;
                }
                else if (type == "yellow")
                {
                    yellow++;
                    total += 15;
                }
                else if (type == "white")
                {
                    white++;
                    total += 20;
                }
                else if (type == "black")
                {
                    black++;
                    Math.Floor(total /= 2);
                }
                else
                {
                    other++;
                }

            }

            Console.WriteLine($"Total points: {Math.Floor(total):f0}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {black}");


        }
    }
}