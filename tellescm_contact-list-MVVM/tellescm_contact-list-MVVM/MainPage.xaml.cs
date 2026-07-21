namespace tellescm_contact_list_MVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage(ViewModels.AddContactViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
