using Movie_Ticket_Booking_System.Interfaces;

namespace Movie_Ticket_Booking_System.Classes;

internal static class BookingHelper
{
    private static int _count = 1;
    //public static int GetCount() => _count;
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
    public static void PrintAll(IPrintable[] printableItems)
    {
        Console.WriteLine("--- BookingHelper.PrintAll ---");
        foreach (var item in printableItems)
        {
            Console.WriteLine(item.Print());
        }
        Console.WriteLine();
    }
}
