using AppShoppingCenter.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppShoppingCenter.ViewModels.Tickets;

[QueryProperty(nameof(Ticket), "ticket")]
public partial class PayPageViewModel : ObservableObject
{

    private double HourValue = 0.07;    
    private Ticket ticket;
    public Ticket Ticket
    {
        get { return ticket; }
        set
        {
            GenerateDateOutAndTolerance(value);
            GeneratePrice(value);
            SetProperty(ref ticket, value);
        }
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
        
        ticket.Price = difTS.TotalMinutes* HourValue;
    }
}
