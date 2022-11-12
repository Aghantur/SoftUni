namespace _04._Easter_Eggs
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());

            int red = 0;
            int green = 0;
            int blue = 0;
            int orange = 0;
            int max = int.MinValue;

            string maxColor = "";

            for (int i = 0; i < eggs; i++)
            {
                string eggColor = Console.ReadLine();

                if (eggColor == "red")
                {
                    red++;

                    if (red>max)
                    {
                        max = red;
                        maxColor = "red";
                    }
                }
                else if (eggColor == "orange")
                {
                    orange++;
                    if (orange > max)
                    {
                        max = orange;
                        maxColor = "orange";
                    }
                }
                else if (eggColor == "blue")
                {
                    blue++;
                    if (blue > max)
                    {
                        max = blue;
                        maxColor = "blue";
                    }
                }
                else if (eggColor == "green")
                {
                    green++;
                    if (green > max)
                    {
                        max = green;
                        maxColor = "green";
                    }
                }
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {max} -> {maxColor}");



        }
    }
}