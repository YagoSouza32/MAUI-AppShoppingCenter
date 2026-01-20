using AppShoppingCenter.CloudServices;
using AppShoppingCenter.CloudServices.Interfaces;

namespace AppShoppingCenter.Configurations;

public static class ServiceConfiguration
{
    public static void AddServiceConfiguration(this IServiceCollection services)
    {
        services.AddTransient<ICinemaService, CinemaService>()
                .AddSingleton<IRestaurantService, RestaurantService>()
                .AddSingleton<IStoreService, StoreService>()
                .AddSingleton<ITicketService, TicketService>();
    }
}
