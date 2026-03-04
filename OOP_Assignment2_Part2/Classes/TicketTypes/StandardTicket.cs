using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes.TicketTypes;

internal class StandardTicket : Ticket, IPrintable
{
    public string SeatNumber { get; set; }
    public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
    {
        SeatNumber = seatNumber;

    }
    public override string Print()
    {
        return base.Print() + $" | Seat: {SeatNumber}";
    }
    public new object Clone()
    {
        return new StandardTicket(this.MovieName, Price, this.SeatNumber);
    }

}
