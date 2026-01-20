using AppShoppingCenter.Views.Cinemas;
using AppShoppingCenter.Views.Restaurants;
using AppShoppingCenter.Views.Stores;
using AppShoppingCenter.Views.Tickets;

namespace AppShoppingCenter.Configurations;

public static class PageConfiguration
{
    public static void AddPageConfiguration(this IServiceCollection services)
    {
        services
            .AddSingleton<AppShell>()                        
            .AddTransient<CinemaListPage>()
            .AddTransient<CinemaDetailPage>()                        
            .AddTransient<EstablishmentDetailPage>()            
            .AddTransient<RestaurantListPage>()
            .AddTransient<StoreListPage>()
            .AddTransient<TicketScanPage>()
            .AddTransient<TicketCameraPage>()
            .AddTransient<TicketPayPage>()
            .AddTransient<TicketResultPage>()
            .AddTransient<TicketListPage>();
    }
}
