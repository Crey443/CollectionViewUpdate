using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using listTest.Models;
using listTest.VeiwModels;
using Xamarin.Forms;

namespace listTest
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.VModelActive(this, EventArgs.Empty);
        }
    }
}
