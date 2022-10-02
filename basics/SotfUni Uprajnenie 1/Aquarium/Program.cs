namespace Aquarium
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int lengthCm = int.Parse(Console.ReadLine());

            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double lossPercent = double.Parse(Console.ReadLine())/100;

            int volumeCM3 = lengthCm * widthCm * heightCm  ;
            double volumeLiters = volumeCM3 / 1000.0;

            double lossLiter = volumeLiters * lossPercent;

            double totalLiters = volumeLiters - lossLiter;
            Console.WriteLine(totalLiters);

        }
    }
}