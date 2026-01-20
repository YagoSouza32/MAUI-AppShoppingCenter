using AppShoppingCenter.ViewModels.Restaurants;

namespace AppShoppingCenter.Views.Restaurants;

public partial class RestaurantListPage : ContentPage
{
    public RestaurantListPage(RestaurantListViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
