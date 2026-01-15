using AppShoppingCenter.ViewModels.Tickets;
using ZXing.Net.Maui;

namespace AppShoppingCenter.Views.Tickets;

public partial class CameraPage : ContentPage
{
    public CameraPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as CameraPageViewModel)?.OnAppearing();
    }

    private void OnBarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        var value = e.Results?.FirstOrDefault()?.Value;

        if (string.IsNullOrWhiteSpace(value))
            return;

        if (BindingContext is CameraPageViewModel vm)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                vm.BarcodeDetectedCommand.Execute(value);
            });
        }
    }
}