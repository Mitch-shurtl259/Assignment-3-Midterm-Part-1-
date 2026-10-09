namespace Assignment_3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Wilson Basketball", typeof(BallDetailPage));
            Routing.RegisterRoute("Blue Lagoon", typeof(LagoonDetailPage));
            Routing.RegisterRoute("Grinches", typeof(GrinchDetailPage));
            Routing.RegisterRoute("Reverse Grinches", typeof(ReverseDetailPage));
        }
    }
}
