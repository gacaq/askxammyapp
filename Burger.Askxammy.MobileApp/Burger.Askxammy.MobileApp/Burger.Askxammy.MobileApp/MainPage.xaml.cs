using Burger.Askxammy.MobileApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Burger.Askxammy.MobileApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutExample());
        }

        private async void ButtonGrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayoutExample());
        }

        private async void ButtonList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BurgerListPage());
        }

        private async void ButtonForm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BurgerCreatePage());
        }
    }
}
