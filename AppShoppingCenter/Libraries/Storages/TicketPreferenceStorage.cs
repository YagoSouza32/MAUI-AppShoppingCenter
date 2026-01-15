using AppShoppingCenter.Models;
using System.Text.Json;

namespace AppShoppingCenter.Libraries.Storages;

public class TicketPreferenceStorage
{
    private readonly string key = "ticket";

    public void Save(Ticket ticket)
    {
        List<Ticket> tickets;

        if (Preferences.Default.ContainsKey(key))
        {
            var ticketsStr = Preferences.Default.Get<string>(key, string.Empty);
            tickets = JsonSerializer.Deserialize<List<Ticket>>(ticketsStr);
        }else
        {
            tickets = new List<Ticket>();
        }
        
        tickets.Add(ticket);
        
        Preferences.Clear();   
        Preferences.Default.Set(key, JsonSerializer.Serialize(tickets));
    }
    public List<Ticket> Load()
    {
        if (Preferences.Default.ContainsKey(key))
        {
            var ticketsStr = Preferences.Default.Get<string>(key, string.Empty);
            var tickets = JsonSerializer.Deserialize<List<Ticket>>(ticketsStr);
            return tickets;
        }

        return new List<Ticket>();
    }
}
