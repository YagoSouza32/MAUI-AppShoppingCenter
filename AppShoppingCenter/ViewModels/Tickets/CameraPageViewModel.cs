using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using ZXing.Net.Maui;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class CameraPageViewModel : ObservableObject
{
    private bool _processing;

    [RelayCommand]
    private async Task BarcodeDetected(string ticketNumber)
    {
        if (_processing)
            return;

        if (string.IsNullOrWhiteSpace(ticketNumber))
            return;

        _processing = true;

        try
        {
            var service = App.Current.Handler.MauiContext.Services.GetService<TicketService>();
            var ticket = service.GetTicket(ticketNumber);

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

            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Shell.Current.GoToAsync("tickets/pay", param);
            });
        }
        catch
        {
            _processing = false;
            throw;
        }
    }
    public void OnAppearing()
    {
        _processing = false;
    }
}
