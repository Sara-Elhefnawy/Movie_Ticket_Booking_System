namespace OOP_Assignment2_Part2.Classes;

internal class Cinema
{
    private readonly Ticket[] _tickets = new Ticket[20];

    public Ticket this[int index]
    {
        get
        {
            if (index >= 0 && index < _tickets.Length)
                return _tickets[index];
            return null!;
        }
        set
        {
            if (index >= 0 && index < _tickets.Length)
            {
                _tickets[index] = value;
            }
        }
    }
    public Ticket GetMovieByName(string movieName)
    {
        if (string.IsNullOrWhiteSpace(movieName))
        {
            return null!;
        }
        for (int i = 0; i < _tickets.Length; i++)
        {
            if (_tickets[i] != null &&
                _tickets[i].MovieName != null &&
                _tickets[i].MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
            {
                return _tickets[i];
            }
        }
        return null!;
    }
    public bool AddTicket(Ticket t)
    {
        if (t == null) return false;

        for (int i = 0; i < _tickets.Length; i++)
        {
            if (_tickets[i] == null)
            {
                _tickets[i] = t;
                return true;
            }
        }
        return false;
    }
}
