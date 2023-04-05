using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int studentCount = 0;
            int standardCount = 0;
            int kidCount = 0;
            double ticketCount = 0;
            string name = "";



            while ((input = Console.ReadLine()) != "Finish")
            {
                name = input;
                int availableTickets = int.Parse(Console.ReadLine());
                double currentTicket = 0;
                for (int i = availableTickets; i > 0; i--)
                {
                    string type = Console.ReadLine();

                    if (type == "End")
                    {
                        break;
                    }else if (type == "student")
                    {
                        studentCount++;
                        ticketCount++;
                        currentTicket++;
                    }else if (type == "standard")
                    {
                        standardCount++;
                        ticketCount++;
                        currentTicket++;
                    }
                    else if (type == "kid")
                    {
                        kidCount++;
                        ticketCount++;
                        currentTicket++;
                    }

                }
                Console.WriteLine($"{name} - {currentTicket / availableTickets * 100:f2}% full.");


            }

            Console.WriteLine($"Total tickets: {ticketCount}");
            Console.WriteLine($"{studentCount / ticketCount * 100:f2}% student tickets.");
            Console.WriteLine($"{standardCount / ticketCount * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidCount / ticketCount * 100:f2}% kids tickets.");
        }
    }
}