using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntelliPA.Views
{
    public partial class ReservePage : ContentPage
    {

        public ReservePage()
        {
            InitializeComponent();
        }

        private async void OnReservationListButtonClicked(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync($"{nameof(ReservationListPage)}");
        }

        private async void OnReserveButtonClicked (object sender, EventArgs args)
        {
            await DisplayAlert("Reservation Success!", 
                "Please wait a couple minutes and check your Reservation History :D", 
                "OK");
        }
    }
}