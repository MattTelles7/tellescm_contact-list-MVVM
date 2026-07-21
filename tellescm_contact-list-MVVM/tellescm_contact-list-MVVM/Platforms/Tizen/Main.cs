using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace tellescm_contact_list_MVVM
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
