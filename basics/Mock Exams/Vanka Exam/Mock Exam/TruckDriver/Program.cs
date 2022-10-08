using System.Security.Cryptography;

namespace TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prihod =0;
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());


            if (season=="Spring" || season=="Autumn")
            {

                if (km<=5000)
                {

                    double pari = (km * 4 * 0.75);
                    prihod = pari -(pari*0.1);
                }
                else if (km>5000 && km<=10000)
                {
                    double pari = (km * 4 * 0.95);
                    prihod = pari - (pari * 0.1);
                }
                else if (km>10000 && km <=20000)
                {
                    double pari = (km * 4 * 1.45);
                     prihod = pari - (pari * 0.1);
                }
                
            }

            if (season == "Summer")
            {

                if (km <= 5000)
                {

                    double pari = (km * 4 * 0.9);
                    prihod = pari - (pari * 0.1);
                }
                else if (km > 5000 && km <= 10000)
                {
                    double pari = (km * 4 * 1.1);
                    prihod = pari - (pari * 0.1);
                }
                else if (km > 10000 && km <= 20000)
                {
                    double pari = (km * 4 * 1.45);
                    prihod = pari - (pari * 0.1);
                }

            }
            if (season == "Winter")
            {

                if (km <= 5000)
                {

                    double pari = (km * 4 * 1.05);
                    prihod = pari - (pari * 0.1);
                }
                else if (km > 5000 && km <= 10000)
                {
                    double pari = (km * 4 * 1.25);
                    prihod = pari - (pari * 0.1);
                }
                else if (km > 10000 && km <= 20000)
                {
                    double pari = (km * 4 * 1.45);
                    prihod = pari - (pari * 0.1);
                }

            }

            Console.WriteLine($"{prihod:F2}");
        }
    }
}