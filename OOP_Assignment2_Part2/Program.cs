using OOP_Assignment2_Part2.Classes;

namespace OOP_Assignment2_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket[] Array = new Ticket[3];
            Cinema cinema = new Cinema();

            Console.WriteLine("========== Ticket Booking ==========\n");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = BuyTicket(i);
                cinema.AddTicket(Array[i]);
            }
            Console.WriteLine("\n========== All Tickets ==========\n");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"Ticket #{i + 1} | {Array[i].MovieName} | ");
                Console.Write($"{Array[i].Type} | Seat: {Array[i].Seat.PrintLocation()} | ");
                Console.Write($"Price: {Array[i].Price} EGP | ");
                Console.Write($"After Tax: {Array[i].PriceAfterTax} EGP\n");
            }
            Console.WriteLine("\n========== Search by Movie ==========\n");
            Console.Write("Enter movie name to search: ");
            string userEnteredMovie = Console.ReadLine()!;
            CheckMovieName(userEnteredMovie);
            Ticket movie = cinema.GetMovieByName(userEnteredMovie);
            if (movie != null)
            {
                Console.Write($"Found: Ticket #{movie.TicketId} | {movie.MovieName} | {movie.Type} | ");
                Console.Write($"{movie.Seat.PrintLocation()} | {movie.Price} EGP");
            }
            else
            {
                Console.WriteLine($"No ticket found for movie: {userEnteredMovie}");
            }
        }
        public static void CheckMovieName(string userMovie)
        {
            bool isValid = false;
            do
            {
                if (String.IsNullOrEmpty(userMovie))
                {
                    Console.WriteLine("movie name can't be null");
                    userMovie = Console.ReadLine()!;
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);
        }
        public static Ticket BuyTicket(int index)
        {
            string? userType;
            char userSeatRow = 'A';
            int userSeatNumber = 0;
            double userPriceNumber = 0;
            TicketType userTicketType = 0;

            Console.WriteLine($"Enter data for Ticket {index + 1}: ");
            Console.Write("Movie Name: ");
            string userMovie = Console.ReadLine()!;

            CheckMovieName(userMovie);

            bool isValid = true;
            do
            {
                Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                userType = Console.ReadLine();

                if (String.IsNullOrEmpty(userType))
                {
                    Console.WriteLine("Ticket Type can't be null");
                }
                else if (!Enum.TryParse(userType, out userTicketType))
                {
                    Console.WriteLine("only 0, 1, 2 available");
                }
                else
                {
                    int userTypeInt = int.Parse(userType);
                    if (userTypeInt >= 0 && userTypeInt <= 2)
                    {
                        isValid = false;
                    }
                    else
                    {
                        Console.WriteLine("Only 0, 1, 2 are available");
                    }
                }
            } while (isValid);

            do
            {
                Console.Write("Seat Row (A-Z): ");
                string userSeat = Console.ReadLine()!;

                if (String.IsNullOrEmpty(userSeat))
                {
                    Console.WriteLine("Seat Row can't be null");
                }
                else if (!char.TryParse(userSeat, out userSeatRow))
                {
                    Console.WriteLine("Seat Row must be a character only");
                }
                else if (!Char.IsLetter(userSeatRow))
                {
                    Console.WriteLine("Seat Row must be a character only");
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            do
            {
                Console.Write("Seat Number: ");
                string userNumber = Console.ReadLine()!;

                if (String.IsNullOrEmpty(userNumber))
                {
                    Console.WriteLine("Seat Number can't be null");
                }
                else if (!int.TryParse(userNumber, out userSeatNumber))
                {
                    Console.WriteLine("Seat Number must be a digits only");
                }
                else if (userSeatNumber < 0)
                {
                    Console.WriteLine("Seat Number can't be negative");
                }
                else
                {
                    isValid = false;
                }
            } while (isValid);

            do
            {
                Console.Write("Price: ");
                string userPrice = Console.ReadLine()!;

                if (String.IsNullOrEmpty(userPrice))
                {
                    Console.WriteLine("Price can't be null");
                }
                else if (!double.TryParse(userPrice, out userPriceNumber))
                {
                    Console.WriteLine("Price must be a digits only");
                }
                else if (userPriceNumber < 0)
                {
                    Console.WriteLine("Price can't be negative\n\n");
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            Ticket ticket = new(userMovie, userTicketType, userSeatNumber, userSeatRow, userPriceNumber);

            return ticket;
        }
    }
}
