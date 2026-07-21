using System.Collections.ObjectModel;
using ContactModel = tellescm_contact_list_MVVM.Models.Contact;

namespace tellescm_contact_list_MVVM.Services;

public class ContactStore
{
    public ObservableCollection<ContactModel> Contacts { get; } = [];
}
