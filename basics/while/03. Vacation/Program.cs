namespace _03._Vacation
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int totalDays = 0;
            int sequenceDays = 0;

            while (currentMoney < neededMoney)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());


                totalDays++;

                if (action == "save")
                {
                    currentMoney += sum;
                    sequenceDays = 0;

                }
                else if (action == "spend")
                {
                    currentMoney -= sum;
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;

                    }

                    sequenceDays++;
                    if (sequenceDays>=5)
                    {
                        break;
                    }
                }

            }

            if (sequenceDays>=5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{totalDays}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }


        }
    }
}