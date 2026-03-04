namespace Movie_Ticket_Booking_System.Classes;

internal class Cinema
{
    private List<Ticket> _tickets;
    private bool _isOpen;
    //private Projector projector;
    public bool AddTicket(Ticket t)
    {
        //projector.TicketList.Add(t);
        if (!_isOpen || _tickets.Count >= 20) return false;
        _tickets.Add(t);
        return true;
    }
    public void PrintAllTickets()
    {
        //Console.WriteLine("\n========== All Tickets ==========\n");
        //foreach (var ticket in projector.TicketList)
        //{
        //    Console.WriteLine(ticket.Print(ticket));
        //}
        if (!_isOpen) return;

        Console.WriteLine("--- All Tickets ---");
        foreach (var ticket in _tickets)
        {
            Console.WriteLine(ticket.Print());
        }
        Console.WriteLine();
    }
    public void OpenCinema()
    {
        Console.WriteLine("========== Cinema Opened ==========");

        _tickets = new List<Ticket>(20);
        _isOpen = true;
        //projector = new Projector();
    }
    public void CloseCinema()
    {
        _isOpen = false;
        Console.WriteLine("========== Cinema Closed ==========");
    }
    //public static void ProcessTicket(Ticket t)
    //{
    //    Console.WriteLine(t?.Print(t));
    //}
}
