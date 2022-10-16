namespace _08._On_Time_for_the_Exam
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine()); 
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());


            int examTotalMinutes = (examHour * 60) + examMinute;
            int arriveTotalMinutes = (arriveHour * 60 )+ arriveMinute;

            int diff = examTotalMinutes - arriveTotalMinutes;

            if (diff<0)
            {

                Console.WriteLine("Late");
                diff = Math.Abs(diff);
                int hoursLate = diff / 60;
                int minutesLate = diff % 60;

                if (hoursLate==0)
                {
                    Console.WriteLine($"{minutesLate} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hoursLate}:{minutesLate:D2} hours after the start");
                }
            }
            else if (diff>=0 && diff<=30)
            {
                Console.WriteLine("On time");

                if (diff>0)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                int hoursEarly = diff / 60;
                int minutesEarly = diff % 60;
                if (hoursEarly==0)
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hoursEarly}:{minutesEarly:d2} hours before the start");
                }
            }
        }
    }
}