namespace Movie_Ticket_Booking_System.Classes.TicketTypes;

internal class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }
    public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, price)
    {
        if (is3D)
        {
            price += 30;
        }
    }
    public override string PrintTicket(Ticket t)
    {
        string test = base.PrintTicket(t);
        return test + $" | IMAX 3D: {Is3D}";
    }
}
