namespace Repaint
{
    using System;
    internal class Program
    {

        static void Main(string[] args)
        {
            int areaNylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());


            double nylonPrice = (areaNylon+2) * 1.5;
            double paintPrice = ((paint + (paint * 0.1)) * 14.5);
            double razreditelPrice = razreditel * 5;

            double torba = 0.4;

            double totalSum = nylonPrice + paintPrice + razreditelPrice + torba;
            double payment = (((totalSum * 0.3)*hoursWork)+totalSum);

            Console.WriteLine(payment);



        }
    }
}