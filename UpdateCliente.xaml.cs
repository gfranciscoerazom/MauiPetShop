using MauiPetShop.Models;
using MauiPetShop.Services;

namespace MauiPetShop;

public partial class UpdateCliente : ContentPage
{
    private readonly IContactoRepository dataService;

    public UpdateCliente(Cliente cliente)
	{
		InitializeComponent();
        dataService = new ContactoService();
        Cliente = cliente;
    }

    public Cliente Cliente { get; }

    private async void SingUpButton_Clicked(object sender, EventArgs e)
    {
		var newCliente = new Cliente
		{
            ClienteId = Cliente.ClienteId,
			Nombre = NameEntry.Text,
			Email = EmailEntry.Text,
			Numero = PhoneNumberEntry.Text,
			Contrasena = (PasswordEntry.Text == ConfirmPasswordEntry.Text) ? PasswordEntry.Text : throw new Exception("Las contraseñas no coinciden")
		};

		if (await dataService.UpdateClienteAsync(newCliente))
		{
            await DisplayAlert("Éxito", "Cliente actualizado correctamente", "OK");
        }
        else
		{
            await DisplayAlert("Error", "No se pudo actualizar el cliente", "OK");
        }

		await Navigation.PopAsync();
    }
}