using MauiPetShop.Models;
using MauiPetShop.Services;

namespace MauiPetShop;

public partial class NuevoContactoPage : ContentPage 
{
    Producto producto;
	private readonly IContactoRepository dataService = new ContactoService();

	public NuevoContactoPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		producto = BindingContext as Producto;
		//Control de edicion
		if (producto != null)
		{
			Nombre.Text = producto.Nombre;
			Apellido.Text = producto.Descripcion;
			Cedula.Text = producto.Precio.ToString();
		}
	}

	public async void OnClickGuardarContacto(object sender, EventArgs e)
	{
		this.BindingContext = this;
		if (producto == null)
		{
			producto = new Producto()
			{
				Nombre = Nombre.Text,
				Descripcion = Apellido.Text,
				Precio = Double.Parse(Cedula.Text)
			};
			await dataService.AddProductoAsync(producto);
		}
		else
		{
			producto.Nombre = Nombre.Text;
			producto.Descripcion = Apellido.Text;
			producto.Precio = Double.Parse(Cedula.Text);

			await dataService.UpdateProductoAsync(producto);
			BindingContext = producto;
		}
		await Navigation.PopAsync();	
	}


}