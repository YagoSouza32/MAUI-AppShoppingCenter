using AppShoppingCenter.CloudServices.Interfaces;
using AppShoppingCenter.Models.Entities;

namespace AppShoppingCenter.CloudServices;

public class TicketService : ITicketService
{
    public Ticket GetTicket(string ticketNumber)
    {
        return MockTicketService.GetTicket(ticketNumber);
    }

    public List<Ticket> GetTickets()
    {
        return MockTicketService.GetTickets();
    }   
}
public class MockTicketService
{
    private static List<Ticket> tickets = new List<Ticket>() {
            new Ticket()
            {
                Id = 1,
                TicketNumber = "209883557324",
                DateIn = new DateTimeOffset(2023, 06, 01, 12, 00, 00, TimeSpan.FromHours(-3)),
            },
            new Ticket()
            {
                Id = 2,
                TicketNumber = "320683687451",
                DateIn = new DateTimeOffset(2023, 06, 01, 15, 00, 00, TimeSpan.FromHours(-3)),
            },
            new Ticket()
            {
                Id = 3,
                TicketNumber = "487920154638",
                DateIn = new DateTimeOffset(2023, 06, 01, 17, 30, 00, TimeSpan.FromHours(-3)),
            },
            new Ticket()
            {
                Id = 4,
                TicketNumber = "598374620115",
                DateIn = new DateTimeOffset(2023, 06, 01, 19, 45, 00, TimeSpan.FromHours(-3)),
            },
            new Ticket()
            {
                Id = 5,
                TicketNumber = "731059284677",
                DateIn = new DateTimeOffset(2023, 06, 01, 21, 10, 00, TimeSpan.FromHours(-3)),
            }
        };

    public static Ticket GetTicket(string ticketNumber)
    {
        return tickets.FirstOrDefault(a => a.TicketNumber == ticketNumber.Replace(" ", string.Empty));
    }
    public static List<Ticket> GetTickets()
    {
        //TODO - Pegar os tickets armazenados no dispositivo.
        return null;
    }
}
