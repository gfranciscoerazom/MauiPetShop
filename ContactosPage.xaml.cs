using MauiPetShop.Models;
using MauiPetShop.Services;
using System.Collections.ObjectModel;

namespace MauiPetShop;

public partial class ContactosPage : ContentPage
{
	private readonly IContactoRepository dataService;

	public ContactosPage()
	{
		InitializeComponent();

		dataService = new ContactoService();

		Console.WriteLine("**********************MainPage");
	}

	public async void onItemSelectedDetails(object sender, SelectedItemChangedEventArgs e)
	{
        Producto producto = (Producto)e.SelectedItem;
		await Navigation.PushAsync(new DetailsPage()
		{
			BindingContext = producto
		});

	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		ListaContactos.ItemsSource = new ObservableCollection<Producto>(await dataService.GetProductosAsync());

	}

	public async void onClickNuevoContacto(object sender, EventArgs e)
	{
		//await Navigation.PushAsync(new NuevoContactoPage());
	}

}