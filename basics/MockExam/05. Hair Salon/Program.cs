namespace _05._Hair_Salon
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            string cmd;
            double price = 0;

            while ((cmd=Console.ReadLine())!="closed")
            {
                if (cmd=="haircut")
                {
                    string postrigvaneType = Console.ReadLine();

                    if (postrigvaneType=="mens")
                    {
                        price += 15;
                    }
                    else if (postrigvaneType=="ladies")
                    {
                        price += 20;
                    }
                    else if (postrigvaneType=="kids")
                    {
                        price += 10;
                    }
                }
                else if (cmd == "color")
                {
                    string postrigvaneType = Console.ReadLine();

                    if (postrigvaneType == "touch up")
                    {
                        price += 20;
                    }
                    else if (postrigvaneType == "full color")
                    {
                        price += 30;
                    }
                }

                if (price>=target)
                {

                    Console.WriteLine($"You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {price}lv.");
                    return;
                }


            }
            if (target>price)
            {
                Console.WriteLine($"Target not reached! You need {target-price}lv. more.");
                Console.WriteLine($"Earned money: {price}lv.");
            }


        }
    }
}