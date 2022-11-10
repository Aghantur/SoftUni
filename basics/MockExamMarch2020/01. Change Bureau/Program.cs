namespace _01._Change_Bureau
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double uan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double uanPrice = (uan * 0.15 * 1.76);
            double bitcoinPrice = (bitcoin * 1168);

            double totalMOney = (uanPrice + bitcoinPrice)/1.95;

            double final = totalMOney - (totalMOney * commission / 100);

            Console.WriteLine($"{final:F2}");

        }
    }
}