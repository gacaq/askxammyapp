using Burger.Askxammy.MobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Burger.Askxammy.MobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BurgerListPage : ContentPage
    {
        public BurgerListPage()
        {
            InitializeComponent();
            BindingContext = new DishesViewModel();
        }
    }
}