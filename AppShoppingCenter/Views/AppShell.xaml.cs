using AppShoppingCenter.Views.Stores;

namespace AppShoppingCenter
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
                        
            Routing.RegisterRoute("detail", typeof(Views.Stores.DetailPage));
            
            Routing.RegisterRoute("cinemas/detail", typeof(Views.Cinemas.DetailPage));
            
            Routing.RegisterRoute("tickets/pay", typeof(Views.Tickets.PayPage));
            Routing.RegisterRoute("tickets/list", typeof(Views.Tickets.ListPage));
            Routing.RegisterRoute("tickets/result", typeof(Views.Tickets.ResultPage));
            Routing.RegisterRoute("tickets/camera", typeof(Views.Tickets.CameraPage));
        }
    }
}
