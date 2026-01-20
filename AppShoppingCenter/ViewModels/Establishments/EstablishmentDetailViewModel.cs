using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Establishments;

[QueryProperty(nameof(Establishment), "establishment")]
public partial class EstablishmentDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Establishment establishment;

    [RelayCommand]
    private async Task OnTapToBack()
    {
        await Shell.Current.GoToAsync("..");
    }

}
