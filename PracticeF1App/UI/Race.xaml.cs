using PracticeF1App.BusinessLogic;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using PracticeF1App.BusinessLogic;

namespace PracticeF1App.UI
{
    public partial class Race : ContentPage
    {
        public Race()
        {
            InitializeComponent();
            LoadRaceData();
        }

        private void LoadRaceData()
        {
            var raceItems = new ObservableCollection<RaceItem>
            {
                new RaceItem { Place = "Race 1", Date = "2024-08-07", Time = "10:00 AM" },
                new RaceItem { Place = "Race 2", Date = "2024-08-08", Time = "2:00 PM" },
                // Add more items as needed
            };

            RaceListView.ItemsSource = raceItems;
        }
    }
}
