using AppShoppingCenter.ViewModels.Tickets;

namespace AppShoppingCenter.Views.Tickets;

public partial class TicketScanPage : ContentPage
{
    public TicketScanPage(TicketScanViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
