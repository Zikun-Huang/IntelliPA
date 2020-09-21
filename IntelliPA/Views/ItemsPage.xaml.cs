using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using IntelliPA.Models;
using IntelliPA.Views;
using IntelliPA.ViewModels;

namespace IntelliPA.Views
{
    public partial class ItemsPage : ContentPage
    {
        //ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            //BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //_viewModel.OnAppearing();
        }

        async void OnEditButtonClicked(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync($"{nameof(AccountEditPage)}");
        }

        async void OnLogoutButtonClicked(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}