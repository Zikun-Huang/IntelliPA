using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace IntelliPA.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Intelligent Parking Assistant";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}