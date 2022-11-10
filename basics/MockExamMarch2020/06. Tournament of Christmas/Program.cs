namespace _06._Tournament_of_Christmas
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int tournaments = int.Parse(Console.ReadLine());
            int wins = 0;
            int loss = 0;
            int winDay = 0;
            int lossDay = 0;
            double money = 0;
            string winOrlose;

            double dayMoney = 0;


            for (int i = 0; i < tournaments; i++)
            {
                wins = 0;
                loss = 0;
                while ((winOrlose = Console.ReadLine()) != "Finish")
                {
                    winOrlose = Console.ReadLine();
                    if (winOrlose == "win")
                    {
                        money += 20;
                        wins++;
                    }
                    else if (winOrlose == "lose")
                    {
                        loss++;
                    }
                }

                if (wins > loss)
                {
                    money += money * 0.1;
                    winDay++;
                }
                else
                {
                    lossDay++;
                }
                dayMoney += money;
                money = 0;

            }
            if (winDay > lossDay)
            {
                dayMoney += dayMoney * 0.2;

                Console.WriteLine($"You won the tournament! Total raised money: {dayMoney:f2}");
            }
            else
            {

                Console.WriteLine($"You lost the tournament! Total raised money: {dayMoney:f2}");
            }


        }
    }
}