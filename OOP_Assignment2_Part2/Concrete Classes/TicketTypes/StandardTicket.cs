using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes.TicketTypes;

internal class StandardTicket : Ticket, IPrintable
{
    public string SeatNumber { get; set; }
    public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
    {
        SeatNumber = seatNumber;

    }
    public override void Print()
    {
        base.Print();
        Console.Write($" | Seat: {SeatNumber}");
    }
    public override decimal CalculatePrice()
    {
         return PriceAfterTax;
    }
}
