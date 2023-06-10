using MauiPetShop.Models;
using MauiPetShop.Services;

namespace MauiPetShop;

public partial class DetailsPage : ContentPage
{
	private readonly IContactoRepository _dataService;

	public DetailsPage()
	{
		InitializeComponent();
		_dataService = new ContactoService();
        Producto productoOb = BindingContext as Producto;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
        Producto productoOb = BindingContext as Producto;

		nombreContacto.Text = productoOb.Nombre;
		apellidoContacto.Text = productoOb.Descripcion;
		cedulaContacto.Text = $"Precio: {productoOb.Precio.ToString()}$";
		imagenContacto.Source = productoOb.Imagen;
        // direccionContacto.Text = productoOb.Cantidad.ToString();
	}

	/* public async void onClickEliminarContacto(object sender, EventArgs e)
	{
        Producto contactoEl = BindingContext as Producto;
		await _dataService.DeleteContactoAsync(contactoEl.ProductoId);
		await Navigation.PopAsync();
	}*/

	public async void onClickEditarContacto(object sender, EventArgs e)
	{
		Producto producto = BindingContext as Producto;
		producto.Cantidad -= int.Parse(CantidadAComprar.Text);
		producto.Ventas += int.Parse(CantidadAComprar.Text);
        await _dataService.UpdateProductoAsync(producto);
        await Navigation.PopAsync();

        //Contacto contactoEd = BindingContext as Contacto;
        /*await Navigation.PushAsync(new NuevoContactoPage()
		{
			BindingContext = BindingContext as Producto
        });*/
    }
}