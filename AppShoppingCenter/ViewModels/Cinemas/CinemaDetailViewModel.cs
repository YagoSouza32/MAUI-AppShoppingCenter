using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Cinemas;

[QueryProperty(nameof(Movie),"movie")]
public partial class CinemaDetailViewModel: ObservableObject
{
    [ObservableProperty]
    private Movie movie;

    [RelayCommand]
    private async Task OnTapCloseGoToMoviesList(MediaElement player)
    {
        player?.Stop();
        await Shell.Current.GoToAsync("..");
    }
}
