namespace Movie_Ticket_Booking_System.Classes.TicketTypes;

internal class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movieName, decimal price, bool is3D = true)
        : base(movieName, is3D ? price + 30 : price)
    {
        Is3D = is3D;
    }

    public override string Print()
    {
        return base.Print() + $" | IMAX | 3D: {(Is3D ? "Yes" : "No")}";
    }
    public new object Clone()
    {
        return new IMAXTicket(this.MovieName, Price, this.Is3D);
    }
}