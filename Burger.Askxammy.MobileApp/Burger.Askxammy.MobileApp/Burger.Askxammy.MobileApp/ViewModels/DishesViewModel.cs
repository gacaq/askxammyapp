using Burger.Askxammy.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Burger.Askxammy.MobileApp.ViewModels
{
    public class DishesViewModel : INotifyPropertyChanged
    {
        private List<Dish> _dishes;
        private Dish _dish;
        
        public List<Dish> dishes
        {
            get { return _dishes; }
            set { _dishes = value; OnPropertyChange(); }
        }

        public Dish dish
        {
            get { return _dish; }
            set { _dish = value; OnPropertyChange(); }
        }

        public DishesViewModel()
        {
            dishes = GetDishesCollection();
        }

        public Command CreateCommand 
        {
            get
            {
                return new Command(() => {

                });
            }
        }

        public Command GetCommand
        {
            get
            {
                return new Command(() => {

                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Dish> GetDishesCollection()
        {
            return new List<Dish>()
            {
                new Dish() { }
            };
        }
    }
}
