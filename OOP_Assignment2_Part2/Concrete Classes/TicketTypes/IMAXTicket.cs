using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes.TicketTypes;

internal class IMAXTicket : Ticket, IPrintable
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movieName, decimal price, bool is3D = true)
        : base(movieName, price)
    {
        Is3D = is3D;
    }
    public override void Print()
    {
        base.Print();
        Console.Write($" | IMAX | 3D: {(Is3D ? "Yes" : "No")}");
    }
    public override decimal CalculatePrice()
    {
        return PriceAfterTax;
    }
}