using AppShoppingCenter.CloudServices.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class TicketCameraViewModel : ObservableObject
{
    private readonly ITicketService _ticketService;
    private bool _processing;

    public TicketCameraViewModel(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [RelayCommand]
    private async Task BarcodeDetected(string ticketNumber)
    {
        if (_processing)
            return;

        if (string.IsNullOrWhiteSpace(ticketNumber))
            return;

        _processing = true;

        var ticket = _ticketService.GetTicket(ticketNumber);

        if (ticket == null)
        {
            await App.Current.MainPage.DisplayAlert(
                "Ticket não encontrado!",
                $"Não localizamos um ticket com o número {ticketNumber}.",
                "OK");

            _processing = false;
            return;
        }

        var param = new Dictionary<string, object>
        {
            { "ticket", ticket }
        };

        await Shell.Current.GoToAsync("tickets/pay", param);
    }

    public void OnAppearing()
    {
        _processing = false;
    }
}
