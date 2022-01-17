using System;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace listTest.VeiwModels
{
    public class VeiwModelBase : ObservableObject
    {
        private string title = string.Empty;

        private string subtitle = string.Empty;

        private bool isBusy;

        private bool isNotBusy = true;

        private bool canLoadMore = true;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                SetProperty(ref title, value, "Title");
            }
        }
        public string Subtitle
        {
            get
            {
                return subtitle;
            }
            set
            {
                SetProperty(ref subtitle, value, "Subtitle");
            }
        }
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                if (SetProperty(ref isBusy, value, "IsBusy"))
                {
                    IsNotBusy = !isBusy;
                }
            }
        }
        public bool IsNotBusy
        {
            get
            {
                return isNotBusy;
            }
            set
            {
                if (SetProperty(ref isNotBusy, value, "IsNotBusy"))
                {
                    IsBusy = !isNotBusy;
                }
            }
        }
        public bool CanLoadMore
        {
            get
            {
                return canLoadMore;
            }
            set
            {
                SetProperty(ref canLoadMore, value, "CanLoadMore");
            }
        }

        public virtual void VModelActive(Page sender, EventArgs eventArgs) { }
        public virtual void VModelInactive(Page sender, EventArgs eventArgs) { }
    }
}
