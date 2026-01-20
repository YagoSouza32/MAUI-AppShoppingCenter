using AppShoppingCenter.Configurations;
using AppShoppingCenter.Libraries.Storages;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ZXing.Net.Maui.Controls;

namespace AppShoppingCenter
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseBarcodeReader()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Ligth.ttf", "OpenSansLight");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                });

            builder.Services.AddServiceConfiguration();
            builder.Services.AddPageConfiguration();
            builder.Services.AddViewModelConfiguration();
            builder.Services.AddSingleton<TicketPreferenceStorage>();
            

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
