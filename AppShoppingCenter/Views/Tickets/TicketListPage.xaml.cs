using AppShoppingCenter.ViewModels.Tickets;

namespace AppShoppingCenter.Views.Tickets;

public partial class TicketListPage : ContentPage
{
    public TicketListPage(TicketListViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
