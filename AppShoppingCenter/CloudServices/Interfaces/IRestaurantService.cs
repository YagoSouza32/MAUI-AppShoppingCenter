using AppShoppingCenter.Models.Entities;

namespace AppShoppingCenter.CloudServices.Interfaces;

public interface IRestaurantService
{
    List<Establishment> GetRestaurants();
}
