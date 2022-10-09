namespace _06._World_Swimming_Record
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSecs = double.Parse(Console.ReadLine());
            double dyljina = double.Parse(Console.ReadLine());
            double timeMeter = double.Parse(Console.ReadLine());

            double zabavqne = Math.Floor(dyljina / 15) * 12.5;

            double time = ((dyljina * timeMeter)+zabavqne);


            if (recordSecs<=time)
            {

                Console.WriteLine($"No, he failed! He was {time - recordSecs:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
            }


        }
    }
}