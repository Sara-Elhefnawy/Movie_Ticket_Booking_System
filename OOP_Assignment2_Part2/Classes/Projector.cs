namespace Movie_Ticket_Booking_System.Classes;

internal class Projector
{
    public List<Ticket> TicketList { get; private set; }

    public Projector()
    {
        TicketList = new List<Ticket>(20);
        Console.WriteLine("Projector started.\r\n \r\n");
    }
}
