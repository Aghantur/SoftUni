namespace _01._Convert_Meters_to_Kilometers
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal m = decimal.Parse(Console.ReadLine());

                sum +=m ;
            }
            Console.WriteLine(sum);

        }
    }
}