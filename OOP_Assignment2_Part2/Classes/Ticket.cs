using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes;

internal class Ticket : IPrintable
{
    private static int _nextTicketId = 1;
    private readonly int _ticketId;
    private decimal _price;
    private double _priceAfterTax;
    public string MovieName { get; set; }
    public Ticket(string movieName, decimal price)
    {
        _ticketId = _nextTicketId++;
        MovieName = movieName;
        _price = price;
        PriceAfterTax = (double)price;
    }
    public double PriceAfterTax
    {
        get { return _priceAfterTax; }
        private set
        {
            _priceAfterTax = value * 1.14;
        }
    }
    public void SetPrice(decimal price)
    {
        if (price > 0)
        {
            _price = price;
            PriceAfterTax = (double)_price;
            Console.WriteLine($"Setting price directly: {_price}");
        }
    }
    public void SetPrice(decimal priceBase, decimal multiplier)
    {
        if (priceBase > 0 && multiplier > 1)
        {
            _price = priceBase * multiplier;
            PriceAfterTax = (double)_price;
            Console.WriteLine($"Setting price directly: {priceBase} x {multiplier} = {_price}");
        }
    }
    public virtual string Print(Ticket t)
    {
        return $"Ticket #{t._ticketId} | {t.MovieName} | Price: {t._price} EGP | After Tax: {t.PriceAfterTax:F2} EGP";
    }
}
