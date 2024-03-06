namespace PetsApp;

public partial class FoodPage : ContentPage
{
	public FoodPage(FoodPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}