namespace OOP_Assignment2_Part2.Classes;

internal class Ticket
{
    private string _movieName;
    private double _price;
    private static int ticketCounter = 0;
    public string MovieName
    {
        get { return _movieName; }
        set
        {
            // If an invalid value is set, keep the previous value.
            if (!string.IsNullOrWhiteSpace(value))
            {
                _movieName = value;
            }
        }
    }
    public TicketType Type { get; set; }
    public SeatLocation Seat { get; set; }
    public double Price
    {
        get { return _price; }
        set
        {
            // If an invalid value is set, keep the previous value.
            if (value > 0)
            {
                _price = value;
            }
        }
    }
    public double PriceAfterTax
    {
        get { return Math.Round(_price * 1.14, 1); }
    }
    public int TicketId { get; private set; }

    public Ticket(string MovieName, TicketType Type, int SeatLocationNumber, char SeatLocationRow, double Price)
    {
        Seat = new SeatLocation(SeatLocationRow, SeatLocationNumber);
        this.MovieName = MovieName;
        this.Type = Type;
        this.Price = Price;

        ticketCounter++;
        TicketId = ticketCounter;
    }

    public static int GetTotalTicketsSold()
    {
        return ticketCounter;
    }
}
