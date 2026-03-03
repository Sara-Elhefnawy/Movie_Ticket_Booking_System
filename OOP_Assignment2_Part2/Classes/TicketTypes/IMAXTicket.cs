using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes.TicketTypes;

internal class IMAXTicket : Ticket, IPrintable
{
    public bool Is3D { get; set; }
    public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, price)
    {
        if (is3D)
        {
            price += 30;
        }
    }
    public override string Print(Ticket t)
    {
        string test = base.Print(t);
        return test + $" | IMAX 3D: {Is3D}";
    }
}
