using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tellescm_contact_list_MVVM.Services;
using ContactModel = tellescm_contact_list_MVVM.Models.Contact;

namespace tellescm_contact_list_MVVM.ViewModels;

public partial class ContactsViewModel(ContactStore contactStore, NavigationService navigationService) : ObservableObject
{
    public ObservableCollection<ContactModel> Contacts => contactStore.Contacts;

    [RelayCommand]
    private Task AddContactAsync()
    {
        return navigationService.NavigateToAddContactAsync();
    }

    [RelayCommand]
    private Task SelectContactAsync(ContactModel? contact)
    {
        return contact is null
            ? Task.CompletedTask
            : navigationService.NavigateToContactDetailsAsync(contact);
    }
}
