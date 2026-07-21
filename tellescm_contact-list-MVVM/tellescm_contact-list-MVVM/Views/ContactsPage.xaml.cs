using tellescm_contact_list_MVVM.ViewModels;

namespace tellescm_contact_list_MVVM.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage(ContactsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ContactList.SelectedItem = null;
    }
}
