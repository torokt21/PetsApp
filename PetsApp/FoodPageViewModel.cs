using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsApp
{
    public partial class FoodPageViewModel
    {
        public ObservableCollection<FoodType> Foods { get; set; }

        public FoodPageViewModel()
        {
            this.Foods = new ObservableCollection<FoodType>()
            {
                new FoodType() { Name = "Bone", Description = "Something to munch on", Quantity = 2},
                new FoodType() { Name = "Fish food", Description = "It makes you go 'GULP'", Quantity = 50},
                new FoodType() { Name = "Dead mouse", Description = "Died of natural causes", Quantity = 20}
            };
        }

        [RelayCommand]
        public async Task EditAsync(FoodType food)
        {
            ShellNavigationQueryParameters parm = new ShellNavigationQueryParameters()
            {
                {"Food", food }
            };

            await Shell.Current.GoToAsync("editfood", parm);
        }


        [RelayCommand]
        public async Task Feed(object sender)
        {

        }
    }
}
