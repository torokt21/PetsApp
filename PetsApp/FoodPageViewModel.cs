using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsApp
{
    [QueryProperty(nameof(PetToFeed), "PetToFeed")]
    public partial class FoodPageViewModel : ObservableObject
    {
        public ObservableCollection<FoodType> Foods { get; set; }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsPetToFeedSelected))]
        public Pet petToFeed;

        public bool IsPetToFeedSelected { get => petToFeed != null; }

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
        public async Task FeedAsync(FoodType food)
        {
            if(food.Quantity > 0)
            {
                this.PetToFeed.LastFedDate = DateTime.Now;
                food.Quantity--;
            }
        }
    }
}
