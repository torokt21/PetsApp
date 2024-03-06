﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsApp
{
    public partial class Pet : ObservableObject
    {
        [ObservableProperty]
        string name;

        [ObservableProperty]
        string species;

        [ObservableProperty]
        DateTime birthDate;

        [ObservableProperty]
        DateTime lastFedDate;
    }
}
