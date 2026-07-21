using Microsoft.Extensions.Logging;
using tellescm_contact_list_MVVM.Services;
using tellescm_contact_list_MVVM.ViewModels;
using tellescm_contact_list_MVVM.Views;

namespace tellescm_contact_list_MVVM
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ContactStore>();
            builder.Services.AddSingleton<NavigationService>();

            builder.Services.AddTransient<AddContactViewModel>();
            builder.Services.AddTransient<ContactsViewModel>();
            builder.Services.AddTransient<ContactDetailsViewModel>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<ContactsPage>();
            builder.Services.AddTransient<ContactDetailsPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
