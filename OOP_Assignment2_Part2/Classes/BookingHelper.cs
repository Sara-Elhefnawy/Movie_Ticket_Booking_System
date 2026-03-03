namespace Movie_Ticket_Booking_System.Classes;

internal class BookingHelper
{
    private static int _count = 1;
    public static int GetCount() => _count;
    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    {
        double totalPrice = numberOfTickets * pricePerTicket;
        if (numberOfTickets >= 5)
        {
            return totalPrice * 0.9;
        }
        return totalPrice;
    }
    public static string GenerateBookingReference()
    {
        return $"BK-{_count++}";
    }
    public void PrintAll(Ticket[] array)
    {
        foreach (var ticket in array)
        {
            ticket.Print(ticket);
        }
    }
}
