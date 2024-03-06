namespace PetsApp;

[QueryProperty(nameof(Pet),"Pet")]
public partial class PetDetailsPage : ContentPage
{
	Pet pet;
	public Pet Pet
	{
		get => pet;
		set
		{
			pet = value;
			OnPropertyChanged();
		}
	}
	public PetDetailsPage()
	{
		InitializeComponent();
		BindingContext=this;
	}
}