namespace Basketball_equipment
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double bootsPrice = tax - (tax * 0.4);
            double equipment = bootsPrice - (bootsPrice * 0.2);
            double ballPrice = equipment * 0.25;
            double accessories = ballPrice * 0.2;

            Console.WriteLine((bootsPrice+equipment+ballPrice+accessories)+tax);


        }
    }
}