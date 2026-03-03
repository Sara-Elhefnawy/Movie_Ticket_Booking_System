using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes.TicketTypes;

internal class VIPTicket : Ticket, IPrintable
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; set; }
    public VIPTicket(string movieName, decimal price) : base(movieName, price)
    {
        LoungeAccess = true;
        ServiceFee = 50;
    }
    public override string Print(Ticket t)
    {
        string test = base.Print(t);
        return test + $" | Lounge: {LoungeAccess} | Service Fee: {ServiceFee} EGP";
    }
}
