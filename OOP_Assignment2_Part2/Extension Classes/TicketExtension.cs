using Movie_Ticket_Booking_System.Classes;

namespace Movie_Ticket_Booking_System.Extension_Classes;

internal static class TicketExtension
{
    public static string FormattedReceipt(this Ticket t)
    {
        return $"""
            ========== RECEIPT ==========
                Movie    : {t.MovieName}
                Type     : {t.GetType().Name}
                Price    : {t.Price}
                Final    : {t.CalculatePrice()}
                Status   : {t._status}
            =============================
            """;
    }
    public static decimal TotalRevenue(this Ticket[] t)
    {
        decimal total = 0;
        foreach (var item in t)
        {
            total += item.CalculatePrice();
        }
        return total;
    }
}
