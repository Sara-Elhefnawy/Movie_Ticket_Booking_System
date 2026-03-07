using Movie_Ticket_Booking_System.Classes;

namespace Movie_Ticket_Booking_System.Partial_Classes;

internal partial class Cinema
{
    public bool AddTicket(Ticket t)
    {
        if (!_isOpen || _tickets is null) return false;

        for (int i = 0; i < _tickets.Length; i++)
        {
            if (_tickets[i] == null)
            {
                _tickets[_ticketCount] = t;
                _ticketCount++;
                return true;
            }
        }

        return false;
    }
    public void OpenCinema()
    {
        Console.WriteLine("========== Cinema Opened ==========");

        _tickets = new Ticket[20];
        _isOpen = true;
    }
    public void CloseCinema()
    {
        _isOpen = false;
        Console.WriteLine("========== Cinema Closed ==========");
    }
}
