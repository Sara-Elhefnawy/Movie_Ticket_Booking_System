using Movie_Ticket_Booking_System.Classes;
using Movie_Ticket_Booking_System.Classes.TicketTypes;

namespace Movie_Ticket_Booking_System;

internal class Program
{
    static void Main(string[] args)
    {
        Cinema cinema = new();
        cinema.OpenCinema();

        StandardTicket standardTicket = new("Inception", 150, "A-5");
        VIPTicket vipTicket = new("Avengers", 200);
        IMAXTicket imaxTicket = new("Dune", 180, false);

        Console.WriteLine("========== SetPrice Test ==========\n");
        standardTicket.SetPrice(150);
        standardTicket.SetPrice(100, 1.5m);

        cinema.AddTicket(standardTicket);
        cinema.AddTicket(vipTicket);
        cinema.AddTicket(imaxTicket);

        cinema.PrintAllTickets();

        Console.WriteLine("\n========== Process Single Ticket ==========\n");
        Cinema.ProcessTicket(vipTicket);

        cinema.CloseCinema();
    }
}
