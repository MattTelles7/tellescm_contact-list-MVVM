using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tellescm_contact_list_MVVM.Services;
using ContactModel = tellescm_contact_list_MVVM.Models.Contact;

namespace tellescm_contact_list_MVVM.ViewModels;

public partial class AddContactViewModel(ContactStore contactStore, NavigationService navigationService) : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(SaveCommand))]
    private string name = string.Empty;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(SaveCommand))]
    private string email = string.Empty;

    [ObservableProperty]
    private string phoneNumber = string.Empty;

    [ObservableProperty]
    private string description = string.Empty;

    [RelayCommand(CanExecute = nameof(CanSave))]
    private async Task SaveAsync()
    {
        contactStore.Contacts.Add(new ContactModel
        {
            Name = Name.Trim(),
            Email = Email.Trim(),
            PhoneNumber = PhoneNumber.Trim(),
            Description = Description.Trim()
        });

        ClearForm();
        await navigationService.NavigateToContactsAsync();
    }

    private bool CanSave()
    {
        return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email);
    }

    private void ClearForm()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        Description = string.Empty;
    }
}
