using PracticeF1App.BusinessLogic;
using System.Collections.ObjectModel;
using PracticeF1App.BusinessLogic;

namespace PracticeF1App.UI
{
    public partial class Team : ContentPage
    {
        public Team()
        {
            InitializeComponent();
            LoadTeamData();
        }

        private void LoadTeamData()
        {
            var teamItems = new ObservableCollection<TeamItem>
            {
                new TeamItem { Name = "Team A" },
                new TeamItem { Name = "Team B" },
                new TeamItem { Name = "Team C" },
                // Add more items as needed
            };

            TeamListView.ItemsSource = teamItems;
        }

        private async void OnTeamTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var teamItem = (TeamItem)e.Item;
                await DisplayAlert("Team Selected", $"You selected: {teamItem.Name}", "OK");
            }
        }
    }
}
