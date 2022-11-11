namespace _01._Agency_Profit
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            int children = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double ticketPriceMan = tickets * price;
            double childrenTicket = price - (price * 0.7);
            double priceChildren = children * childrenTicket;

            double totalValue = ticketPriceMan + priceChildren + (tickets + children) * tax;

            Console.WriteLine($"The profit of your agency from {name} tickets is {totalValue*0.2:f2} lv.");

        }
    }
}