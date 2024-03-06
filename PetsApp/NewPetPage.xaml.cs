namespace PetsApp;

public partial class NewPetPage : ContentPage
{
    public Pet NewPet { get; set; }
    public NewPetPage()
	{
		InitializeComponent();
		NewPet= new Pet();
		BindingContext = this;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var param = new ShellNavigationQueryParameters
                {
                    {"NewPet",NewPet }
                };
        Shell.Current.GoToAsync("..", param);
    }
}