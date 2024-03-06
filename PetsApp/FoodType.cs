using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsApp
{
    public partial class FoodType : ObservableObject
    {
        [ObservableProperty]
        string name;

        [ObservableProperty]
        string description;

        [ObservableProperty]
        int quantity;
    }
}
