using tellescm_contact_list_MVVM.ViewModels;
using ContactModel = tellescm_contact_list_MVVM.Models.Contact;

namespace tellescm_contact_list_MVVM.Views;

public partial class ContactDetailsPage : ContentPage
{
    private readonly ContactDetailsViewModel viewModel;

    public ContactDetailsPage(ContactDetailsViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
    }

    public void LoadContact(ContactModel contact)
    {
        viewModel.LoadContact(contact);
    }
}
