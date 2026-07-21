using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tellescm_contact_list_MVVM.Services;
using ContactModel = tellescm_contact_list_MVVM.Models.Contact;

namespace tellescm_contact_list_MVVM.ViewModels;

public partial class ContactDetailsViewModel(NavigationService navigationService) : ObservableObject
{
    private ContactModel? contact;

    [ObservableProperty]
    private string name = string.Empty;

    [ObservableProperty]
    private string email = string.Empty;

    [ObservableProperty]
    private string phoneNumber = string.Empty;

    [ObservableProperty]
    private string description = string.Empty;

    public void LoadContact(ContactModel selectedContact)
    {
        contact = selectedContact;
        Name = selectedContact.Name;
        Email = selectedContact.Email;
        PhoneNumber = selectedContact.PhoneNumber;
        Description = selectedContact.Description;
    }

    [RelayCommand]
    private async Task SaveAsync()
    {
        if (contact is null)
        {
            return;
        }

        contact.Name = Name.Trim();
        contact.Email = Email.Trim();
        contact.PhoneNumber = PhoneNumber.Trim();
        contact.Description = Description.Trim();

        await navigationService.GoBackAsync();
    }

    [RelayCommand]
    private Task BackAsync()
    {
        return navigationService.GoBackAsync();
    }
}
