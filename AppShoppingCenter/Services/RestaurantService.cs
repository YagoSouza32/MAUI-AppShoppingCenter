using AppShoppingCenter.Models;

namespace AppShoppingCenter.Services;

public class RestaurantService
{
    public List<Establishment> GetRestaurants()
    {
        return new List<Establishment>
        {
            new Establishment
            {
                Name = "Gourmet Garden",
                Type = Models.Enums.EEstablishmentType.Restaurant,
                Description = "A fine dining experience with a diverse menu of international cuisines.",
                Location = "First Floor, Unit 110"
            },
            new Establishment
            {
                Name = "Pizza Palace",
                Type = Models.Enums.EEstablishmentType.Restaurant,
                Description = "Delicious wood-fired pizzas with a variety of toppings to choose from.",
                Location = "Ground Floor, Unit 015"
            },
            new Establishment
            {
                Name = "Sushi World",
                Type = Models.Enums.EEstablishmentType.Restaurant,
                Description = "Fresh sushi and sashimi prepared by expert chefs.",
                Location = "Second Floor, Unit 220"
            }
        };
    }
}
