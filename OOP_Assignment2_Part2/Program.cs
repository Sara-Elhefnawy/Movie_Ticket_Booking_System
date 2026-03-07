using Movie_Ticket_Booking_System.Classes;
using Movie_Ticket_Booking_System.Classes.TicketTypes;
using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System;

internal class Program
{
    static void Main(string[] args)
    {
        Cinema cinema = new();
        cinema.OpenCinema();

        StandardTicket standardTicket = new("Inception", 80, "A-5");
        VIPTicket vipTicket = new("Avengers", 200);
        IMAXTicket imaxTicket = new("Dune", 130, false);

        standardTicket.Book();
        vipTicket.Book();
        imaxTicket.Book();

        cinema.AddTicket(standardTicket);
        cinema.AddTicket(vipTicket);
        cinema.AddTicket(imaxTicket);

        cinema.PrintAllTickets();

        Console.WriteLine("========== Clone Test ==========\n");
        VIPTicket vipClone = (VIPTicket)vipTicket.Clone();
        vipClone.MovieName = "Interstellar";

        Console.Write("Original :");
        vipTicket.Print();

        Console.Write("\n\nClone    : \n");
        vipClone.Print();

        Console.WriteLine("========== After Cancellation ==========\n");

        standardTicket.Cancel();
        Console.Write("\n");
        standardTicket.Print();

        IPrintable[] printableTickets = [standardTicket, vipTicket, imaxTicket];
        BookingHelper.PrintAll(printableTickets);

        cinema.CloseCinema();
    }
}
