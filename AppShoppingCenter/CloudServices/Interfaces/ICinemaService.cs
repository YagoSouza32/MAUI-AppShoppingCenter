using AppShoppingCenter.Models.Entities;

namespace AppShoppingCenter.CloudServices.Interfaces;

public interface ICinemaService
{
    List<Movie> GetMovies();
}
