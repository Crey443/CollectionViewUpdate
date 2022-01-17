using System;
using System.Threading.Tasks;
using System.Windows.Input;
using listTest.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace listTest.VeiwModels
{
    public class MainViewModel : VeiwModelBase
    {
        public ObservableRangeCollection<MainModel> Locations { get; set; } = new ObservableRangeCollection<MainModel>();

        public ICommand RefreshCommand { get; }

        public MainViewModel()
        {
            RefreshCommand = new AsyncCommand(Refresh);
        }

        public override void VModelActive(Page sender, EventArgs eventArgs)
        {
            base.VModelActive(sender, eventArgs);
            var locs = new MainModel() { Image = "https://club-l1.de/wp-content/uploads/2019/11/dsc08645-1200x800.jpg", Name = "Test" };
            Locations.Add(locs);

            foreach (MainModel loc in Locations)
            {
                loc.Name = "Update";
            }
        }

        private async Task Refresh()
        {
            IsBusy = true;


            var locs = new MainModel() { Image = "https://club-l1.de/wp-content/uploads/2019/11/dsc08645-1200x800.jpg", Name = "Test"};
            Locations.Add(locs);

            foreach (MainModel loc in Locations)
            {
                loc.Name = "Update";
            }

            IsBusy = false;
        }
    }
}
