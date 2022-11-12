namespace _06._Easter_Decoration
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double averagePrice = 0;

            for (int i = 0; i < n; i++)
            {
                double currentClient = 0;
                int counter = 0;
                string product = Console.ReadLine();

                while (product != "Finish")
                {
                    if (product == "basket")
                    {
                        currentClient += 1.5;
                        counter++;
                    }
                    else if (product == "wreath")
                    {
                        currentClient += 3.8;
                        counter++;
                    }
                    else if (product == "chocolate bunny")
                    {
                        currentClient += 7;
                        counter++;
                    }

                    product = Console.ReadLine();
                }
                if (counter % 2 == 0)
                {
                    currentClient -= currentClient * 0.2;
                }

                averagePrice+=currentClient;
                Console.WriteLine($"You purchased {counter} items for {currentClient:f2} leva.");

            }
            Console.WriteLine($"Average bill per client is: {averagePrice/n:f2} leva.");


        }
    }
}