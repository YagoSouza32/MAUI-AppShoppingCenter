using AppShoppingCenter.Libraries.Storages;
using AppShoppingCenter.Libraries.Storages.Interfaces;

namespace AppShoppingCenter.Configurations;

public static class StorageConfiguration
{
    public static void AddStorageConfiguration(this IServiceCollection services)
    {
        services.AddSingleton<ITicketStorage, TicketPreferenceStorage>();
    }
}
