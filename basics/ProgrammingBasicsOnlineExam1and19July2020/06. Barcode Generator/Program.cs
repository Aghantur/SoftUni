namespace _06._Barcode_Generator
{


    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int edinicaX = x / 1000;
            int deseticaX = (x / 100) % 10;
            int stoticaX = (x / 10) % 10;
            int hilqdaX = x % 10;
            
            int edinicaY = y / 1000;
            int deseticaY = (y / 100) % 10;
            int stoticaY = (y / 10) % 10;
            int hilqdaY = y % 10;




            for (int i = edinicaX; i <= edinicaY; i++)
            {
                for (int j = deseticaX; j <= deseticaY; j++)
                {
                    for (int k = stoticaX; k <= stoticaY; k++)
                    {

                        for (int l = hilqdaX; l <= hilqdaY; l++)
                        {
                            bool oddX = i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0;

                            if (oddX)
                            {

                                Console.Write($"{i}{j}{k}{l} ");

                            }

                        }
                    }
                }
            }

        }
    }
}