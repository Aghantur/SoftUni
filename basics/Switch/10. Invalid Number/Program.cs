namespace _10._Invalid_Number
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            if (a==0 ||(a>=100 && a <=200))
            {

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
            

        }
    }
}