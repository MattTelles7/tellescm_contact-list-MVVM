using Microsoft.Extensions.DependencyInjection;
using tellescm_contact_list_MVVM.Views;
using ContactModel = tellescm_contact_list_MVVM.Models.Contact;

namespace tellescm_contact_list_MVVM.Services;

public class NavigationService(IServiceProvider serviceProvider)
{
    public Task NavigateToContactsAsync()
    {
        return Navigation.PushAsync(serviceProvider.GetRequiredService<ContactsPage>());
    }

    public Task NavigateToAddContactAsync()
    {
        return Navigation.PopToRootAsync();
    }

    public Task NavigateToContactDetailsAsync(ContactModel contact)
    {
        var page = serviceProvider.GetRequiredService<ContactDetailsPage>();
        page.LoadContact(contact);
        return Navigation.PushAsync(page);
    }

    public Task GoBackAsync()
    {
        return Navigation.PopAsync();
    }

    private static INavigation Navigation =>
        Application.Current?.Windows.FirstOrDefault()?.Page?.Navigation
        ?? throw new InvalidOperationException("The navigation stack is not available.");
}
