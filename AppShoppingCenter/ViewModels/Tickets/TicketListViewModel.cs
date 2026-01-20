using AppShoppingCenter.Libraries.Storages;
using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class TicketListViewModel : ObservableObject
{
    private readonly TicketPreferenceStorage _ticketPreferenceStorage;

    [ObservableProperty]
    private List<Ticket> tickets;

    public TicketListViewModel(TicketPreferenceStorage ticketPreferenceStorage)
    {
        _ticketPreferenceStorage = ticketPreferenceStorage;
        Tickets = _ticketPreferenceStorage.Load();
    }
}
