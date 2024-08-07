using PracticeF1App.UI;
using System;
using System.Threading.Tasks; // Add this using directive if not already present

namespace PracticeF1App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RaceScheduleClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Race());
        }

        private async void TeamClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Team());
        }

        private async void RaceResultClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Result());
        }
    }
}
