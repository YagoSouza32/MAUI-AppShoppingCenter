using AppShoppingCenter.ViewModels.Stores;

namespace AppShoppingCenter.Views.Stores;

public partial class StoreListPage : ContentPage
{
    public StoreListPage(StoreListViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
