using AppShoppingCenter.CloudServices.Interfaces;
using AppShoppingCenter.Models.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Stores;

public partial class StoreListViewModel : ObservableObject
{
    private readonly IStoreService _storeService;

    [ObservableProperty]
    private string textSearch;

    private List<Establishment> establishmentsFull;

    [ObservableProperty]
    private List<Establishment> establishmentsFiltered;

    public StoreListViewModel(IStoreService storeService)
    {
        _storeService = storeService;

        establishmentsFull = _storeService.GetStores();
        EstablishmentsFiltered = establishmentsFull.ToList();
    }

    partial void OnTextSearchChanged(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            EstablishmentsFiltered = establishmentsFull.ToList();
            return;
        }

        EstablishmentsFiltered = establishmentsFull
            .Where(e => e.Name.Contains(value, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    [RelayCommand]
    private async Task OnTapEstablishmentGoToDetailPage(Establishment establishment)
    {
        if (establishment == null)
            return;

        var navigationParameter = new Dictionary<string, object>
        {
            { "establishment", establishment }
        };

        await Shell.Current.GoToAsync("detail", navigationParameter);
    }
}
