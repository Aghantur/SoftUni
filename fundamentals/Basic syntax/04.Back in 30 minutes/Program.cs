namespace _03._Passed_or_Failed
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 30;

            if (minute >= 60)
            {
                hour++;
                minute -= 60;
            }

            if (hour >= 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minute:D2}");

        }
    }
}