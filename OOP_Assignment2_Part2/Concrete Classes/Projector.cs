namespace Movie_Ticket_Booking_System.Classes;

internal class Projector
{
    public List<Ticket> TicketList { get; private set; }

    public Projector()
    {
        TicketList = new List<Ticket>(20);
    }
}
