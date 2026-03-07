using Movie_Ticket_Booking_System.Classes;

namespace Movie_Ticket_Booking_System.Extension_Classes;

internal static class TicketExtension
{
    public static void FormattedReceipt(this Ticket t)
    {
        Console.WriteLine($"""
            ========== RECEIPT ==========
                Movie    : {t.MovieName}
                Type     : {t.GetType().Name}
                Price    : {t.Price}
                Final    : {t.CalculatePrice()}
                Status   : {t._status}
            =============================
            """);
    }
    public static void TotalRevenue(this Ticket[] t)
    {
        decimal total = 0;
        foreach (var item in t)
        {
            total += item.CalculatePrice();
        }
        Console.WriteLine($"Total Revenue: {total}");
    }
}
