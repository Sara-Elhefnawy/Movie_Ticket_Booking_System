namespace Movie_Ticket_Booking_System.Classes;

internal class Cinema
{
    private Projector projector;
    public void AddTicket(Ticket t)
    {
        projector.TicketList.Add(t);
    }
    public void PrintAllTickets()
    {
        Console.WriteLine("\n========== All Tickets ==========\n");
        foreach (var ticket in projector.TicketList)
        {
            Console.WriteLine(ticket.Print(ticket));
        }
    }
    public void OpenCinema()
    {
        Console.WriteLine("========== Cinema Opened ==========");

        projector = new Projector();
    }
    public void CloseCinema() => Console.WriteLine("========== Cinema Closed ==========");
    public static void ProcessTicket(Ticket t)
    {
        Console.WriteLine(t?.Print(t));
    }
}
