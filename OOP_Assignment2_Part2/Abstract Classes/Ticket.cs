using Movie_Ticket_Booking_System.Enums;
using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes;

internal abstract class Ticket : IPrintable, IBookable
{
    private static int _nextTicketId = 1;
    private readonly int _ticketId;

    private decimal _price;
    internal TicketStatus _status;
    public string MovieName { get; set; }
    public decimal PriceAfterTax { get; private set; }
    private void ApplyTax(decimal percentage)
    {
        PriceAfterTax = Price * percentage;
    }
    public decimal Price
    {
        get { return _price; }
        protected set
        {
            if (value > 0)
                _price = value;
        }
    }
    public Ticket(string movieName, decimal price)
    {
        _ticketId = _nextTicketId++;
        MovieName = movieName;
        _price = price > 0 ? price : 0;
        ApplyTax(1.14m);
        _status = TicketStatus.Available;
    }
    
    public virtual void Print()
    {
        Console.Write($"[Ticket #{_ticketId}] {MovieName} | Price: {_price} | After Tax: {PriceAfterTax:F2} | Booked: {_status}");
    }
    public virtual bool Book()
    {
        if (_status == TicketStatus.Available)
        {
            _status = TicketStatus.Booked;
            return true;
        }
        return false;
    }

    public virtual bool Cancel()
    {
        if (_status == TicketStatus.Booked)
        {
            _status = TicketStatus.Available;
            return true;
        }
        return false;
    }
    public abstract decimal CalculatePrice();
}
