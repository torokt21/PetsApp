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
    [QueryProperty(nameof(NewPet), "NewPet")]
    public partial class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<Pet> Pets { get; set; }

        [ObservableProperty]
        Pet selectedPet;

        public Pet NewPet
        {
            set
            {
                Pets.Add(value);
            }
        }
        public MainPageViewModel()
        {
            Pets = new ObservableCollection<Pet>();
            Pets.Add(new Pet() { Name = "Fifi", Species = "Dog", BirthDate = new DateTime(2009, 12, 15) });
            Pets.Add(new Pet() { Name = "Sam", Species = "Cat", BirthDate = new DateTime(2021, 1, 1) });
            Pets.Add(new Pet() { Name = "Sherlock", Species = "Blue Tongue Skink", BirthDate = new DateTime(2023, 9, 1) });
        }

        [RelayCommand]
        public async Task ShowPetDetailsAsync()
        {
            if (SelectedPet != null)
            {
                var param = new ShellNavigationQueryParameters
                {
                    {"Pet",SelectedPet }
                };
                await Shell.Current.GoToAsync("petdetails",param);
            }
            
        }

        [RelayCommand]
        public async Task AddNewPetAsync()
        {
            await Shell.Current.GoToAsync("newpet");
        }

        [RelayCommand]
        public async Task FeedAsync(Pet pet)
        {
            ShellNavigationQueryParameters parm = new ShellNavigationQueryParameters()
            {
                {"PetToFeed", pet }
            };

            await Shell.Current.GoToAsync("//Main/FoodPage", parm);
        }
    }
}
