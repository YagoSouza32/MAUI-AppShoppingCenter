using AppShoppingCenter.ViewModels.Cinemas;

namespace AppShoppingCenter.Views.Cinemas;

public partial class CinemaDetailPage : ContentPage
{
    bool firstTime = false;

    public CinemaDetailPage(CinemaDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel; 
    }

    private void PlayPause(object sender, TappedEventArgs e)
    {
        var btn = (Image)sender;

        if (!firstTime)
        {
            var mediaWidthHalf = player.Width / 2 - btn.Width + 10;
            var mediaHeightHalf = player.Height / 2 - btn.Height;

            btn_playpause.TranslateTo(-mediaWidthHalf, mediaHeightHalf, 500);
            firstTime = true;
            MovieText.TranslateTo(0, 40);
        }

        if (player.CurrentState == CommunityToolkit.Maui.Core.MediaElementState.Playing)
        {
            player.Pause();
            btn_playpause.Source = ImageSource.FromFile("play.png");
        }
        else
        {
            player.Play();
            btn_playpause.Source = ImageSource.FromFile("pause.png");
        }
    }
}
