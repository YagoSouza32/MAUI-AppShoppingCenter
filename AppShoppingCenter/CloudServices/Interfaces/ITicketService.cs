using AppShoppingCenter.Models.Entities;

namespace AppShoppingCenter.CloudServices.Interfaces;

public interface ITicketService
{
    Ticket GetTicket(string ticketNumber);
    List<Ticket> GetTickets();
}
