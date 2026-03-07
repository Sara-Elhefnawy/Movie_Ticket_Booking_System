using Movie_Ticket_Booking_System.Classes.TicketTypes;
using Movie_Ticket_Booking_System.Extension_Classes;
using Movie_Ticket_Booking_System.Partial_Classes;

namespace Movie_Ticket_Booking_System;

internal class Program
{
    static void Main(string[] args)
    {
        Cinema cinema = new();
        cinema.OpenCinema();

        // a. Try to create a plain Ticket object and show (in a comment) that the compiler prevents it.
        //Ticket ticket = new Ticket();
        //CS0144: Cannot create an instance of the abstract type or interface 'Ticket'

        // b. Create one of each ticket type with hardcoded data. Book all three.
        StandardTicket standardTicket = new("Inception", 80, "A5");
        VIPTicket vipTicket = new("Avengers", 200);
        IMAXTicket imaxTicket = new("Dune", 130, true);

        standardTicket.Book();
        vipTicket.Book();
        imaxTicket.Book();

        // c. Add all three tickets to a Cinema and print them all
        //      (the print should go through the Cinema's reporting partial file).
        cinema.AddTicket(standardTicket);
        cinema.AddTicket(vipTicket);
        cinema.AddTicket(imaxTicket);

        cinema.PrintAllTickets();

        // d. Use polymorphism: loop through a Ticket[] array and call the abstract method on each to show each type calculates differently.
        Console.WriteLine("--- Polymorphism: Final Price per Ticket ---"); 
        foreach (var ticket in cinema.Statistics())
        {
            Console.WriteLine($"{ticket.GetType().Name} => Final Price: {ticket.CalculatePrice()}");
        }

        // e. Call an extension method on a ticket to generate a receipt string and print it.
        Console.WriteLine("--- Extension Method: Receipt ---"); 
        vipTicket.FormattedReceipt();

        // f. Call an extension method on the ticket array to calculate and print the total revenue.
        Console.WriteLine("--- Extension Method: Total Revenue ---"); 
        cinema.Statistics().TotalRevenue();

        // g. Close the Cinema.
        cinema.CloseCinema();
    }
}
