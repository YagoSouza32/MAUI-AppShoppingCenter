using AppShoppingCenter.CloudServices.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class TicketScanViewModel : ObservableObject
{
    private readonly ITicketService _ticketService;

    [ObservableProperty]
    private string ticketNumber = string.Empty;

    public TicketScanViewModel(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [RelayCommand]
    private async Task Scan()
    {
        await Shell.Current.GoToAsync("tickets/camera");
    }

    [RelayCommand]
    private async Task CheckTicketNumber()
    {
        if (TicketNumber?.Length < 15)
            return;

        var ticket = _ticketService.GetTicket(TicketNumber);

        if (ticket == null)
        {
            await App.Current.MainPage.DisplayAlert(
                "Ticket inválido",
                $"O ticket número {TicketNumber} não foi encontrado. Tente novamente.",
                "OK");

            return;
        }

        var parameters = new Dictionary<string, object>
        {
            { "ticket", ticket }
        };

        await Shell.Current.GoToAsync("tickets/pay", parameters);

        TicketNumber = string.Empty;
    }

    [RelayCommand]
    private async Task List()
    {
        await Shell.Current.GoToAsync("tickets/list");
    }
}
