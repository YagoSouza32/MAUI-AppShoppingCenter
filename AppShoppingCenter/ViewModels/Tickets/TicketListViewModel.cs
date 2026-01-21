using AppShoppingCenter.Libraries.Storages.Interfaces;
using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class TicketListViewModel : ObservableObject
{
    private readonly ITicketStorage _ticketStorage;

    [ObservableProperty]
    private List<Ticket> tickets;

    public TicketListViewModel(ITicketStorage ticketStorage)
    {
        _ticketStorage = ticketStorage;
        Tickets = _ticketStorage.Load();
    }
}
