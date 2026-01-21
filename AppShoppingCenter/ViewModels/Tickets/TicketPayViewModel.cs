using AppShoppingCenter.Libraries.Storages.Interfaces;
using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Tickets;

[QueryProperty(nameof(Ticket), "ticket")]
public partial class TicketPayViewModel : ObservableObject
{
    private readonly ITicketStorage _ticketStorage;

    private double HourValue = 0.07;

    [ObservableProperty]
    private string pixCode = "00020126360014BR.GOV.BCB.PIX0114+5573999...";

    private Ticket ticket;
    public Ticket Ticket
    {
        get => ticket;
        set
        {
            GenerateDateOutAndTolerance(value);
            GeneratePrice(value);
            SetProperty(ref ticket, value);
        }
    }

    public TicketPayViewModel(ITicketStorage ticketStorage)
    {
        _ticketStorage = ticketStorage;
    }

    private void GenerateDateOutAndTolerance(Ticket ticket)
    {
        var random = new Random();
        var hour = random.Next(0, 12);
        var minute = random.Next(0, 60);

        ticket.DateOut = ticket.DateIn.AddHours(hour).AddMinutes(minute);
        ticket.DateTolerance = ticket.DateOut.AddMinutes(30);
    }

    private void GeneratePrice(Ticket ticket)
    {
        var dif = ticket.DateOut.Ticks - ticket.DateIn.Ticks;
        var difTS = new TimeSpan(dif);

        ticket.Price = difTS.TotalMinutes * HourValue;
    }

    [RelayCommand]
    private async Task CopyAndPaste()
    {
        await Clipboard.Default.SetTextAsync(PixCode);

        await Task.Delay(2000);

        _ticketStorage.Save(Ticket);

        var param = new Dictionary<string, object>
        {
            { "ticket", Ticket }
        };

        await Shell.Current.GoToAsync("tickets/result", param);
    }
}
