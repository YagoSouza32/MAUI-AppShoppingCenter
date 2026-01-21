using AppShoppingCenter.Libraries.Storages.Interfaces;
using AppShoppingCenter.Models.Entities;
using System.Text.Json;

namespace AppShoppingCenter.Libraries.Storages;

public class TicketPreferenceStorage : ITicketStorage
{
    private const string Key = "ticket";

    public void Save(Ticket ticket)
    {
        var tickets = Load();
        tickets.Add(ticket);

        Preferences.Default.Set(Key, JsonSerializer.Serialize(tickets));
    }

    public List<Ticket> Load()
    {
        if (!Preferences.Default.ContainsKey(Key))
            return new List<Ticket>();

        var ticketsStr = Preferences.Default.Get(Key, string.Empty);

        if (string.IsNullOrWhiteSpace(ticketsStr))
            return new List<Ticket>();

        return JsonSerializer.Deserialize<List<Ticket>>(ticketsStr)
               ?? new List<Ticket>();
    }
}
