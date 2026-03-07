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
    public override void Print()
    {
        base.Print();
        Console.Write($" | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee}");
    }
    public new object Clone()
    {
        return new VIPTicket(this.MovieName, Price);
    }
}
