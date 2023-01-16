namespace _03._Vacation
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            int ppl = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();


            double money = 0;

            if (type == "Students")
            {

                if (day == "Friday")
                {
                    money = 8.45;
                }
                else if (day == "Saturday") 
                {
                    money = 9.8;
                }
                else if (day == "Sunday")
                {
                    money = 10.46;
                }

                if (ppl>=30)
                {
                    money *= 0.85;
                }

            }
            else if (type == "Business")
            {

                if (day == "Friday")
                {
                    money = 10.90;
                }
                else if (day == "Saturday")
                {
                    money = 15.6;

                }
                else if (day == "Sunday")
                {
                    money = 16;
                }

                if (ppl >= 100)
                {
                    ppl -= 10;
                }
            }
            else if (type == "Regular")
            {

                if (day == "Friday")
                {
                    money = 15;
                }
                else if (day == "Saturday")
                {
                    money = 20;
                }
                else if (day == "Sunday")
                {
                    money = 22.5;
                }

                if (ppl>=10 && ppl <=20)
                {
                    money *= 0.95;
                }
            }
            double totalprice = ppl* money;
            Console.WriteLine($"Total price: {totalprice:f2}");
        }
    }
}