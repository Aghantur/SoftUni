namespace SotfUni_Uprajnenie_1
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            int pages=int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysRead = int.Parse(Console.ReadLine());

            int hoursNeeded = pages / pagesPerHour;
            int hoursPerDay = hoursNeeded/ daysRead;

            Console.WriteLine(hoursPerDay);


        }
    }
}