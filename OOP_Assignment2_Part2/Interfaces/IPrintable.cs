using Movie_Ticket_Booking_System.Classes;

namespace Movie_Ticket_Booking_System.Interfaces;

internal interface IPrintable
{
    // any printable object in the system (tickets, receipts, etc.)
    // can print itself through a single common method

    string Print(Ticket t);

    //string Print(Receipt r);
}
