namespace _05._Suitcases_Load
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = double.Parse(Console.ReadLine());
            string command;
            int cnt = 1; //broim kufari

            while ((command = Console.ReadLine()) != "End")
            {
                double obem = double.Parse(command);
               
                if (cnt % 3 == 0)
                {
                    
                    obem += obem * 0.1;
                    total -= obem;
                   
                    if (total < 0)
                    {
                        cnt--;
                        break;
                    }
                }
                else
                {
                    total -= obem;
                    if (total < 0)
                    {
                        cnt--;
                        break;
                    }
                }
                cnt++;
            }
            if (total < 0)
            {
                Console.WriteLine("No more space!");
                Console.WriteLine($"Statistic: {cnt} suitcases loaded.");

            }
            else
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {cnt} suitcases loaded.");

            }
        }
    }
}