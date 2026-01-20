using AppShoppingCenter.ViewModels.Tickets;
using ZXing.Net.Maui;

namespace AppShoppingCenter.Views.Tickets;

public partial class TicketCameraPage : ContentPage
{
    private TicketCameraViewModel ViewModel => BindingContext as TicketCameraViewModel;

    public TicketCameraPage(TicketCameraViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel?.OnAppearing();
    }

    private void OnBarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        var value = e.Results?.FirstOrDefault()?.Value;

        if (string.IsNullOrWhiteSpace(value))
            return;

        MainThread.BeginInvokeOnMainThread(() =>
        {
            ViewModel?.BarcodeDetectedCommand.Execute(value);
        });
    }
}
