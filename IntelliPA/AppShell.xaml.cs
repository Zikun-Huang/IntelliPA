using System;
using System.Collections.Generic;
using System.Windows.Input;
using IntelliPA.ViewModels;
using IntelliPA.Views;
using Xamarin.Essentials;
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

        private async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void OnHelpButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HelpPage");
        }
    }
}
