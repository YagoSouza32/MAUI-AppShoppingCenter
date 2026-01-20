using AppShoppingCenter.CloudServices.Interfaces;
using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Cinemas;

public partial class CinemaListViewModel : ObservableObject
{
    private readonly ICinemaService _cinemaService;

    [ObservableProperty]
    private List<Movie> movies;

    public CinemaListViewModel(ICinemaService cinemaService)
    {
        _cinemaService = cinemaService;
        Movies = _cinemaService.GetMovies();
    }

    [RelayCommand]
    private async Task OnTapMovieGoToDetailPage(Movie movie)
    {
        if (movie == null)
            return;

        var param = new Dictionary<string, object>
        {
            { "movie", movie }
        };

        await Shell.Current.GoToAsync("detail", param);
    }
}
