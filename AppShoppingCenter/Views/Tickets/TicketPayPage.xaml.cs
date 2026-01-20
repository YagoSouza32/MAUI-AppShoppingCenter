using AppShoppingCenter.ViewModels.Tickets;

namespace AppShoppingCenter.Views.Tickets;

public partial class TicketPayPage : ContentPage
{
    public TicketPayPage(TicketPayViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
