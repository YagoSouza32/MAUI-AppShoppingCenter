using AppShoppingCenter.ViewModels.Cinemas;

namespace AppShoppingCenter.Views.Cinemas;

public partial class CinemaDetailPage : ContentPage
{
    public CinemaDetailPage(CinemaDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
