using AppShoppingCenter.CloudServices.Interfaces;
using AppShoppingCenter.Models.Entities;
using AppShoppingCenter.Models.Enums;

namespace AppShoppingCenter.CloudServices;

public class RestaurantService : IRestaurantService
{
    public List<Establishment> GetRestaurants()
    {
        return MockRestaurantService.GetRestaurants();
    }
}

public class MockRestaurantService
{
    public static List<Establishment> GetRestaurants()
    {
        return new List<Establishment>
        {
            new Establishment
            {
                Id = 1,
                Name = "Outback Steakhouse",
                Type = EEstablishmentType.Restaurant,
                Description = "Restaurante com inspiração australiana, conhecido por carnes grelhadas, ribs e porções generosas.",
                Location = "Piso Térreo, Loja 045",
                Phone = "(11) 3003-0001",
                Cover = "https://cdn.outback.com.br/wp-data/wp-content/uploads/2025/02/restaurante_generica.jpg",
                Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTkzWL-4OYcKQMv9EdNjfMGVAFXA2WKZI1ew&s"
            },
            new Establishment
            {
                Id = 2,
                Name = "Madero",
                Type = EEstablishmentType.Restaurant,
                Description = "Hamburgueria gourmet com foco em ingredientes de alta qualidade e receitas artesanais.",
                Location = "Piso Superior, Loja 210",
                Phone = "(11) 3003-0002",
                Cover = "https://www.jornaldocomercio.com/_midias/jpg/2016/08/30/unnamed__2_-553981.jpg",
                Logo = "https://elephant-file-storage.nyc3.digitaloceanspaces.com/public/images/mos/logo%201___FG5cN8a1nE9-5w9F8F2TN.jpg"
            },
            new Establishment
            {
                Id = 3,
                Name = "Spoleto",
                Type = EEstablishmentType.Restaurant,
                Description = "Culinária italiana rápida, com massas personalizadas preparadas na hora.",
                Location = "Praça de Alimentação, Loja 312",
                Phone = "(11) 3003-0003",
                Cover = "https://assets.multiplan.com.br/Multiplan/filer_public/b4/f8/b4f89611-9942-402f-9300-2b873ce491f9/spoletocapa.jpg?ims=x800",
                Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhu3CL2vCSg5WhLZzI-DC0etMITg_-GAo3yg&s"
            },
            new Establishment
            {
                Id = 4,
                Name = "Coco Bambu",
                Type = EEstablishmentType.Restaurant,
                Description = "Especializado em frutos do mar, com pratos bem servidos para compartilhar.",
                Location = "Piso Gourmet, Loja 401",
                Phone = "(11) 3003-0004",
                Cover = "https://cocobambu.com.br/web/image/16693-7cd6af96/FOTOS%20COCO%20BAMBU_NY_DIA%2001-008.webp",
                Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQn7CiLEL64gMquCjsaBY0qEnlr-SJE0oBcyA&s"
            }
        };
    }
}