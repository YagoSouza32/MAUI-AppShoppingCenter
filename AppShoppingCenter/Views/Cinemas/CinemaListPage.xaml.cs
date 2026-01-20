using AppShoppingCenter.ViewModels.Cinemas;

namespace AppShoppingCenter.Views.Cinemas;

public partial class CinemaListPage : ContentPage
{
    private CinemaListViewModel ViewModel => BindingContext as CinemaListViewModel;

    public CinemaListPage(CinemaListViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
