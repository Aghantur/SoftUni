namespace _11._Multiplication_Table_2._0
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{n} X {m} = {n*m}");
                m++;
            } while (m<=10);

        }
    }
}