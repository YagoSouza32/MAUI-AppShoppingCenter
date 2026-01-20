using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppShoppingCenter.ViewModels.Tickets;

[QueryProperty(nameof(Ticket), "ticket")]
public partial class TicketResultViewModel : ObservableObject
{
    [ObservableProperty]
    private Ticket ticket;

    [ObservableProperty]
    private int tolerance = 30;
}
