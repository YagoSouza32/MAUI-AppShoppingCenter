using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class ScanPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string ticketNumber;


    [RelayCommand]
    private void Scan()
    {
        Shell.Current.GoToAsync("tickets/pay");
    }

    [RelayCommand]
    private async Task CheckTicketNumber()
    {
        if (TicketNumber?.Length < 15)
            return;

        var service = App.Current.Handler.MauiContext.Services.GetService<Services.TicketService>();
        var ticket = service.GetTicket(TicketNumber);

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
    private void List()
    {
        Shell.Current.GoToAsync("tickets/list");
    }
}
