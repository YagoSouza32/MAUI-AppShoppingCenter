using AppShoppingCenter.ViewModels.Cinemas;
using AppShoppingCenter.ViewModels.Establishments;
using AppShoppingCenter.ViewModels.Restaurants;
using AppShoppingCenter.ViewModels.Stores;
using AppShoppingCenter.ViewModels.Tickets;

namespace AppShoppingCenter.Configurations;

public static class ViewModelConfiguration
{
    public static void AddViewModelConfiguration(this IServiceCollection services)
    {
        services            
            .AddTransient<CinemaListViewModel>()
            .AddTransient<CinemaDetailViewModel>()                        
            .AddTransient<RestaurantListViewModel>()
            .AddTransient<StoreListViewModel>()
            .AddTransient<EstablishmentDetailViewModel>()                        
            .AddTransient<TicketScanViewModel>()
            .AddTransient<TicketCameraViewModel>()
            .AddTransient<TicketPayViewModel>()
            .AddTransient<TicketResultViewModel>()
            .AddTransient<TicketListViewModel>();
    }
}
