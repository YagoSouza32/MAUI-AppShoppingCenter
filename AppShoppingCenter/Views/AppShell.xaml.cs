using AppShoppingCenter.Views.Stores;

namespace AppShoppingCenter
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
                        
            Routing.RegisterRoute("detail", typeof(Views.Stores.EstablishmentDetailPage));
            
            Routing.RegisterRoute("cinemas/detail", typeof(Views.Cinemas.CinemaDetailPage));
            
            Routing.RegisterRoute("tickets/pay", typeof(Views.Tickets.TicketPayPage));
            Routing.RegisterRoute("tickets/list", typeof(Views.Tickets.TicketListPage));
            Routing.RegisterRoute("tickets/result", typeof(Views.Tickets.TicketResultPage));
            Routing.RegisterRoute("tickets/camera", typeof(Views.Tickets.TicketCameraPage));
        }
    }
}
