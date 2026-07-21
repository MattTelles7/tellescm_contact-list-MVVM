namespace tellescm_contact_list_MVVM
{
    public partial class App : Application
    {
        private readonly IServiceProvider services;

        public App(IServiceProvider services)
        {
            InitializeComponent();
            this.services = services;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var mainPage = services.GetRequiredService<MainPage>();
            return new Window(new NavigationPage(mainPage));
        }
    }
}
