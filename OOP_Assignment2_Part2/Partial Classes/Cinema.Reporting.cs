using Movie_Ticket_Booking_System.Classes;

namespace Movie_Ticket_Booking_System.Partial_Classes;

internal partial class Cinema
{
    private Ticket[] _tickets;
    private int _ticketCount;
    private bool _isOpen;
    public void PrintAllTickets()
    {
        if (!_isOpen) return;

        Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");
        foreach (var ticket in _tickets)
        {
            if (ticket != null)
            {
                ticket.Print();
                Console.WriteLine();
            }
        }
    }
    public Ticket[] Statistics()
    {
        Ticket[] result = new Ticket[_ticketCount];
        for (int i = 0; i < _ticketCount; i++)
        {
            result[i] = _tickets[i];
        }
        return result;
    }
}
