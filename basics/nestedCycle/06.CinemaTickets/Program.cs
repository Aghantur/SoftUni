namespace _06.CinemaTickets
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            string movieName;

            while ((movieName = Console.ReadLine()) != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());

                int takenSeats = 0;
                string ticketType;

                while (takenSeats < freeSeats && (ticketType = Console.ReadLine()) != "End")
                {
                    takenSeats++;

                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                }

                double projectionPercentage = ((double)takenSeats / freeSeats) * 100;
                Console.WriteLine($"{movieName} - {projectionPercentage:f2}% full.");

            }

            double totalTicketsCount = standardTickets + studentTickets + kidTickets;
            double studentPercentage = (studentTickets / totalTicketsCount) * 100;
            double standardPercentage = (standardTickets / totalTicketsCount) * 100;
            double kidPercentage = (kidTickets / totalTicketsCount) * 100;

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standardPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidPercentage:f2}% kids tickets.");

        }
    }
}