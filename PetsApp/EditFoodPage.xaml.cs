using CommunityToolkit.Mvvm.Input;

namespace PetsApp;

[QueryProperty(nameof(Food), "Food")]
public partial class EditFoodPage : ContentPage
{
    FoodType food;
    public FoodType Food
    {
        get => food;
        set
        {
            food = value;
            OnPropertyChanged();
        }
    }
    public EditFoodPage()
	{
		InitializeComponent();
        this.BindingContext = this;
	}

    [RelayCommand]
    public async Task SaveAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}