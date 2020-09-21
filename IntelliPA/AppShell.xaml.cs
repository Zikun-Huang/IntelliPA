using System;
using System.Collections.Generic;
using IntelliPA.ViewModels;
using IntelliPA.Views;
using Xamarin.Forms;

namespace IntelliPA
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AccountEditPage), typeof(AccountEditPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
