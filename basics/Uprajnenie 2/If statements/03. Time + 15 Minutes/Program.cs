namespace _03._Time___15_Minutes
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());


            minute += 15;

            if (minute>=60)
            {
                hour += 1;
                minute -= 60;
            }
            if (hour>=24)
            {
                hour -= 24;

                
            }
            //if (minute<=9)
            //{
            //    Console.WriteLine($"{hour}:0{minute}");
            //}
            //else
            //{
            //    Console.WriteLine($"{hour}:{minute}");
            //}

            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}