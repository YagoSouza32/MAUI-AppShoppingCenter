using AppShoppingCenter.Models.Entities;

namespace AppShoppingCenter.CloudServices.Interfaces;

public interface IStoreService
{
    List<Establishment> GetStores();
}
