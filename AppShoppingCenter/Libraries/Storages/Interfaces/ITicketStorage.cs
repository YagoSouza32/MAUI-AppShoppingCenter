using AppShoppingCenter.Models.Entities;

namespace AppShoppingCenter.Libraries.Storages.Interfaces;

public interface ITicketStorage
{
    void Save(Ticket ticket);
    List<Ticket> Load();
}
