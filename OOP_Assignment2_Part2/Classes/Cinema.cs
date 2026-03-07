using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes;

internal class Cinema
{
    private List<IPrintable> _tickets = [];
    private bool _isOpen;
    public bool AddTicket(IPrintable t)
    {
        if (!_isOpen || _tickets.Count >= 20) return false;
        _tickets.Add(t);
        return true;
    }
    public void PrintAllTickets()
    {
        if (!_isOpen) return;

        Console.WriteLine("--- All Tickets ---");
        foreach (var ticket in _tickets)
        {
            ticket.Print();
        }
        Console.WriteLine();
    }
    public void OpenCinema()
    {
        Console.WriteLine("========== Cinema Opened ==========");

        _tickets = new List<IPrintable>(20);
        _isOpen = true;
    }
    public void CloseCinema()
    {
        _isOpen = false;
        Console.WriteLine("========== Cinema Closed ==========");
    }
}
