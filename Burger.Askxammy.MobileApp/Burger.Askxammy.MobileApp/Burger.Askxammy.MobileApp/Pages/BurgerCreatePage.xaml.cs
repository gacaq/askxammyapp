using Burger.Askxammy.MobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Burger.Askxammy.MobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BurgerCreatePage : ContentPage
    {
        public BurgerCreatePage()
        {
            InitializeComponent();
            BindingContext = new DishesViewModel();
        }
    }
}