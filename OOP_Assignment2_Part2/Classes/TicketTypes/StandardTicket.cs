namespace Movie_Ticket_Booking_System.Classes.TicketTypes;

internal class StandardTicket : Ticket
{
    public string SeatNumber { get; set; }
    public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
    {
        SeatNumber = seatNumber;
    }
    public override string PrintTicket(Ticket t)
    {
        string test = base.PrintTicket(t);
        return test + $" | Seat: {SeatNumber}";
    }
}
