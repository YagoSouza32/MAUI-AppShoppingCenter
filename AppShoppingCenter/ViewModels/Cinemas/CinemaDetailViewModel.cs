using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Cinemas;

[QueryProperty(nameof(Movie), "movie")]
public partial class CinemaDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Movie movie;

    [RelayCommand]
    private async Task TapCloseGoToMoviesList()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    private async Task OpenTrailer()
    {
        if (!string.IsNullOrWhiteSpace(Movie?.Trailer))
            await Launcher.OpenAsync(Movie.Trailer);
    }
}
