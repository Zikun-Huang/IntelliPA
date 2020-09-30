using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntelliPA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParkPage : ContentPage
    {
        private double _scale = 0;

        public ParkPage()
        {
            InitializeComponent();
            _scale = ParkButton.Scale;
        }

        private async void OnParkButtonTapped(object sender, EventArgs e)
        {
            await ParkButton.ScaleTo(_scale * 1.05, 100);
            await ParkButton.ScaleTo(_scale, 100);
        }

        private async void OnCarParkMapButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(CarParkMapPage)}");
        }
    }
}